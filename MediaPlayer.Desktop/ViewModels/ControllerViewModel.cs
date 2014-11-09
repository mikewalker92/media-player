namespace MediaPlayer.Desktop.ViewModels
{
    using Caliburn.Micro;
    using System.Windows.Controls;
    using System.Windows.Data;
    using MediaPlayer.Core;
    using System.Threading.Tasks;

    public class ControllerViewModel : Screen
    {
        public Song Song { get; set; }

        public ControllerViewModel()
        {
            Song = new Song();
        }
            public void PlayMedia()
            {
                Song.Play();
            }

            public void PauseMedia()
            {
                Song.Pause();
            }

            public void StopMedia()
            {
                Song.Stop();
            }
    }
}
