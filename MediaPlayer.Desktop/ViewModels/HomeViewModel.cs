
namespace MediaPlayer.Desktop.ViewModels
{
    using System.Windows;
    using Caliburn.Micro;
    using MediaPlayer.Desktop.Helpers;
    using MediaPlayer.Core;

    public class HomeViewModel : Screen
    {
        private ControllerViewModel _controllerViewModel;
        private MediaTabViewModel _mediaTabViewModel;
        private NowPlayingViewModel _nowPlayingViewModel;
        private SongQueueViewModel _songQueueViewModel;
        private TitleViewModel _titleViewModel;
        private ViewModelFactory viewModelFactory;

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

        public MediaTabViewModel MediaTabViewModel
        {
            get { return _mediaTabViewModel; }
            set
            {
                _mediaTabViewModel = value;
                NotifyOfPropertyChange(() => MediaTabViewModel);
            }
        }

        public NowPlayingViewModel NowPlayingViewModel
        {
            get { return _nowPlayingViewModel; }
            set
            {
                _nowPlayingViewModel = value;
                NotifyOfPropertyChange(() => NowPlayingViewModel);
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
            this.viewModelFactory = (ViewModelFactory)viewModelFactory;
            ControllerViewModel = viewModelFactory.Get<ControllerViewModel>();
            MediaTabViewModel = viewModelFactory.Get<MediaTabViewModel>();
            NowPlayingViewModel = viewModelFactory.Get<NowPlayingViewModel>();
            SongQueueViewModel = viewModelFactory.Get<SongQueueViewModel>();
            TitleViewModel = viewModelFactory.Get<TitleViewModel>();

            Initialize();
        }

        public void Initialize()
        {
            var paradise = new Song();

            var songViewModel = viewModelFactory.Get<SongViewModel>();
            songViewModel.Song = paradise;
            SongQueueViewModel.AddToQueue(songViewModel);

            ControllerViewModel.Song = paradise;
        }
    }
}
