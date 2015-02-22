namespace MediaPlayer.ViewModels
{
    using System.Windows;
    using Caliburn.Micro;
    using MediaPlayer.Desktop;
    using System.Collections.Generic;
    using MediaPlayer.Helpers;

    public class HomeViewModel : Screen
    {
        private ControllerViewModel _controllerViewModel;
        private TrackListViewModel _mediaTabViewModel;
        private SongQueueViewModel _songQueueViewModel;
        private TitleViewModel _titleViewModel;
        private IViewModelFactory viewModelFactory;

        #region Properties

        public ControllerViewModel ControllerViewModel
        {
            get { return _controllerViewModel; }
            set
            {
                _controllerViewModel = value;
                NotifyOfPropertyChange(() => ControllerViewModel);
            }
        }

        public TrackListViewModel MediaTabViewModel
        {
            get { return _mediaTabViewModel; }
            set
            {
                _mediaTabViewModel = value;
                NotifyOfPropertyChange(() => MediaTabViewModel);
            }
        }

        public SongQueueViewModel SongQueueViewModel
        {
            get { return _songQueueViewModel; }
            set
            {
                _songQueueViewModel = value;
                NotifyOfPropertyChange(() => SongQueueViewModel);
            }
        }

        public TitleViewModel TitleViewModel
        {
            get { return _titleViewModel; }
            set
            {
                _titleViewModel = value;
                NotifyOfPropertyChange(() => TitleViewModel);
            }
        }

        #endregion

        public HomeViewModel(IViewModelFactory viewModelFactory)
        {
            this.viewModelFactory = viewModelFactory;
            ControllerViewModel = viewModelFactory.Get<ControllerViewModel>();
            MediaTabViewModel = viewModelFactory.Get<TrackListViewModel>();
            SongQueueViewModel = viewModelFactory.Get<SongQueueViewModel>();
            TitleViewModel = viewModelFactory.Get<TitleViewModel>();
        }
    }
}
