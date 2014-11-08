
namespace MediaPlayer.Desktop.ViewModels
{
    using Caliburn.Micro;

    public class SongQueueViewModel : Conductor<SongViewModel>.Collection.AllActive
    {
        public void AddToQueue(SongViewModel songViewModel)
        {
            Items.Add(songViewModel);
        }
    }
}
