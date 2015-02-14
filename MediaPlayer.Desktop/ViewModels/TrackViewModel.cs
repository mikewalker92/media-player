namespace MediaPlayer.ViewModels
{
    using Caliburn.Micro;
    using MediaPlayer.DataModels;

    public class TrackViewModel : Screen
    {
        public Track Track { get; set; }

        public string Title
        {
            get
            {
                return Track.Title;
            }
        }
    }
}
