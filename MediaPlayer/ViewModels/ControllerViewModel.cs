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
            Track = new Track();
            Track.PrimaryArtist = new Artist { Name = "Sia" };
            Track.Album = new Album { Title = "1000 Forms of Fear" };
            Track.Title = "Elastic Heart";
            Track.Image = "E:/Music/MediaPlayer/AlbumArt/exampleImage.png";
        }
    }
}
