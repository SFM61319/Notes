﻿using System;

using Notes.Services.Ink;
using Notes.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Notes.Views
{
    // For more information regarding Windows Ink documentation and samples see https://github.com/microsoft/TemplateStudio/blob/main/docs/UWP/pages/ink.md
    public sealed partial class InkSmartCanvasPage : Page
    {
        public InkSmartCanvasViewModel ViewModel { get; } = new InkSmartCanvasViewModel();

        public InkSmartCanvasPage()
        {
            InitializeComponent();

            Loaded += (sender, eventArgs) =>
            {
                SetCanvasSize();

                var strokeService = new InkStrokesService(inkCanvas.InkPresenter);
                var analyzer = new InkAsyncAnalyzer(inkCanvas, strokeService);
                var selectionRectangleService = new InkSelectionRectangleService(inkCanvas, selectionCanvas, strokeService);

                ViewModel.Initialize(
                    strokeService,
                    new InkLassoSelectionService(inkCanvas, selectionCanvas, strokeService, selectionRectangleService),
                    new InkNodeSelectionService(inkCanvas, selectionCanvas, analyzer, strokeService, selectionRectangleService),
                    new InkPointerDeviceService(inkCanvas),
                    new InkUndoRedoService(inkCanvas, strokeService),
                    new InkTransformService(drawingCanvas, strokeService),
                    new InkFileService(inkCanvas, strokeService));
            };
        }

        private void SetCanvasSize()
        {
            inkCanvas.Width = Math.Max(canvasScroll.ViewportWidth, 1000);
            inkCanvas.Height = Math.Max(canvasScroll.ViewportHeight, 1000);
        }
    }
}
