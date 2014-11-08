namespace MediaPlayer.Desktop.ViewModels
{
    using Caliburn.Micro;
    using MediaPlayer.Core;

    public class SongViewModel : Screen
    {
        #region Properties

        public Song Song { get; set; }

        public string Title
        {
            get { return Song.Title; }
        }
        
        public string Artist
        {
            get { return Song.Artist; }
        }

        public string Album
        {
            get { return Song.Album; }
        }

        #endregion
    }
}
