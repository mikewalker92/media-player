namespace MediaPlayer.ViewModels
{
    using Caliburn.Micro;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Threading.Tasks;
    using MediaPlayer.Helpers;
    using MediaPlayer.DataModels;

    public class ControllerViewModel : Screen
    {
        private IViewModelFactory viewModelFactory;
        private ControlPanelViewModel _controlPanelViewModel;
        private NowPlayingDisplayViewModel _nowPlayingDisplayViewModel;
        private Track _track;

        #region Properties

        public ControlPanelViewModel ControlPanelViewModel
        {
            get { return _controlPanelViewModel; }
            set
            {
                _controlPanelViewModel = value;
                NotifyOfPropertyChange(() => ControlPanelViewModel);
            }
        }

        public NowPlayingDisplayViewModel NowPlayingDisplayViewModel
        {
            get { return _nowPlayingDisplayViewModel; }
            set
            {
                _nowPlayingDisplayViewModel = value;
                NotifyOfPropertyChange(() => NowPlayingDisplayViewModel);
            }
        }

        public Track Track
        {
            get
            {
                return _track;
            }
            set
            {
                if (value == _track)
                {
                    return;
                }
                _track = value;
                NowPlayingDisplayViewModel.Track = value;
                ControlPanelViewModel.Track = value;
            }
        }

        #endregion

        public ControllerViewModel(IViewModelFactory viewModelFactory)
        {
            this.viewModelFactory = viewModelFactory;
            ControlPanelViewModel = viewModelFactory.Get<ControlPanelViewModel>();
            NowPlayingDisplayViewModel = viewModelFactory.Get<NowPlayingDisplayViewModel>();
            setNewTrack();
        }

        private void setNewTrack()
        {
            Album myloXyloto = new Album { Title = "Mylo Xyloto" };
            Artist coldplay = new Artist { Name = "Coldplay" };
            Track = new Track { 
                PrimaryArtist = coldplay,
                Album = myloXyloto, Title = "paradise",
                Image = "C:/Users/Michael/Music/MediaPlayer/AlbumArt/coldplay-paradise.JPG", 
                Uri = "file://C:/Users/Michael/Music/MediaPlayer/Music/paradise.wav" };
        }
    }
}
