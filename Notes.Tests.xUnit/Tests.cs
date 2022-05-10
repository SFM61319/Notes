using System;

using Notes.ViewModels;

using Xunit;

namespace Notes.Tests.XUnit
{
    // TODO: Add appropriate tests
    public class Tests
    {
        [Fact]
        public void TestMethod1()
        {
        }

        // TODO: Add tests for functionality you add to CameraViewModel.
        [Fact]
        public void TestCameraViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new CameraViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to InkDrawPictureViewModel.
        [Fact]
        public void TestInkDrawPictureViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new InkDrawPictureViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to InkDrawViewModel.
        [Fact]
        public void TestInkDrawViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new InkDrawViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to InkSmartCanvasViewModel.
        [Fact]
        public void TestInkSmartCanvasViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new InkSmartCanvasViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to SettingsViewModel.
        [Fact]
        public void TestSettingsViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new SettingsViewModel();
            Assert.NotNull(vm);
        }

        // TODO: Add tests for functionality you add to TabViewViewModel.
        [Fact]
        public void TestTabViewViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new TabViewViewModel();
            Assert.NotNull(vm);
        }
    }
}
