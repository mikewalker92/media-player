namespace MediaPlayer.ViewModels
{
    using Caliburn.Micro;
    using System.Windows.Controls;

    public class TrackListViewModel : Screen
    {
        protected override void OnViewLoaded(object view)
        {
            PopulateTrackList();
        }

        public void PopulateTrackList()
        {

        }
    }
}
