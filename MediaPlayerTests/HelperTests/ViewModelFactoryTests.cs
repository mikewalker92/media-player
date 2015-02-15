
namespace DesktopTests.HelperTests
{
    using System;
    using NUnit.Framework;
    using FakeItEasy;
    using FluentAssertions;
    using MediaPlayer.Desktop.Helpers;
    using Caliburn.Micro;

    [TestFixture]
    public class ViewModelFactoryTests
    {
        private ViewModelFactory viewModelFactory;
        private Func<Type, string, object> originalGetInstance;

        [SetUp]
        public void SetUp()
        {
            var viewModelFactory = new ViewModelFactory();
            originalGetInstance = IoC.GetInstance;
        }

        [TearDown]
        public void TearDown()
        {
            IoC.GetInstance = originalGetInstance;
        }

        [Test]
        public void View_model_factory_returns_an_instance_of_requested_window()
        {
            // When
            var model = viewModelFactory.Get<TestViewModel>();

            // Then
            model.Should().BeOfType<TestViewModel>();
        }

        [Test]
        public void Factory_delegates_creation_of_view_models_to_IoC()
        {
            // Given
            var modelFromIoC = new TestViewModel();
            IoC.GetInstance = (service, key) => modelFromIoC;

            // When
            var testViewModel = viewModelFactory.Get<TestViewModel>();

            // Then
            testViewModel.Should().Be(modelFromIoC);
        }

        private class TestViewModel { }
    }
}
