
namespace MediaPlayer.Desktop
{
    using Autofac;
    using Caliburn.Micro;
    using Caliburn.Metro.Autofac;
    using MahApps.Metro;
    using MediaPlayer.Desktop.ViewModels;

    class Bootstrapper : AutofacBootstrapper<HomeViewModel>
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<HomeViewModel>();
        }
    }
}
