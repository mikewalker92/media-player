namespace MediaPlayer.ViewModels
{
    using Caliburn.Micro;
    using MediaPlayer.DataModels;
    using MediaPlayer.Helpers;
    using System.Collections.ObjectModel;
    using System.Windows.Media;

    public class TrackViewModel : Screen
    {
        private IImageSourceFactory imageSourceFactory;

        public TrackViewModel(IImageSourceFactory imageSourceFactory)
        {
            this.imageSourceFactory = imageSourceFactory;
        }

        #region Properties

        private Track _track;

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
                NotifyOfPropertyChange(() => Title);
                NotifyOfPropertyChange(() => Artist);
                NotifyOfPropertyChange(() => Album);

            }
        }

        

        public string Title
        {
            get
            {
                return Track.Title;
            }
        }

        public string Artist
        {
            get
            {
                return Track.PrimaryArtist.Name;
            }
        }

        public string Album
        {
            get
            {
                var album = Track.Album;
                if (album == null)
                {
                    return string.Empty;
                }
                return Track.Album.Title;
            }
        }

        public ImageSource Image
        {
            get
            {
                return imageSourceFactory.GetForUrl(Track.Image);
            }
        }
        #endregion
    }
}
