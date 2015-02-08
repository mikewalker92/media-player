namespace MediaPlayer
{
    using Autofac;
    using Caliburn.Micro;
    using Caliburn.Metro.Autofac;
    using MahApps.Metro;
    using MediaPlayer.ViewModels;
    using MediaPlayer.Helpers;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Markup;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    class Bootstrapper : AutofacBootstrapper<HomeViewModel>
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            SetCulture();
            DisplayRootViewFor<HomeViewModel>();
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            var mediaPlayerAssemblies = Assembly.GetExecutingAssembly().LoadMediaPlayerExtensions();
            builder.RegisterAssemblyTypes(mediaPlayerAssemblies.ToArray()).AsImplementedInterfaces();
            builder.Register(x => Application.Current.MainWindow).SingleInstance();
        }

        private static void SetCulture()
        {
            FrameworkElement.LanguageProperty.OverrideMetadata(
                typeof(FrameworkElement),
                new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.Name)));
        }

    }
}
