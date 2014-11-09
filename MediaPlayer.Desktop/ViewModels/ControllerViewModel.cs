namespace MediaPlayer.Desktop.ViewModels
{
    using Caliburn.Micro;
    using System.Windows.Controls;
    using System.Windows.Data;
    using MediaPlayer.Core;
    using System.Threading.Tasks;

    public class ControllerViewModel : Screen
    {
        private Song paradise;

        public ControllerViewModel()
        {
            paradise = new Song();
        }
            public void PlayMedia()
            {
                paradise.Play();
            }

            public void PauseMedia()
            {
                paradise.Pause();
            }

            public void StopMedia()
            {
                paradise.Stop();
            }
    }
}
