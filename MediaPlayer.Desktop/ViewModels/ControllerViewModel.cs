namespace MediaPlayer.Desktop.ViewModels
{
    using Caliburn.Micro;
    using System.Windows.Controls;
    using System.Windows.Data;
    using MediaPlayer.Core;
    using System.Threading.Tasks;

    public class ControllerViewModel : Screen
    {
        private SongPlayer songPlayer;
        private Song paradise;

        public ControllerViewModel()
        {
            paradise = new Song();
            paradise.FileLocation = @"E:\paradise.wav";
        }
            public void PlayMusic()
            {
                paradise.Play();
            }
    }
}
