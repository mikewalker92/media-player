namespace MediaPlayer.Services

{
    using MediaPlayer.DataModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMediaController 
    {
        void setUri(Uri uri);
        void Play();
        void Pause();
        void Stop();
    }

    public class MediaController : IMediaController
    {
        private System.Windows.Media.MediaPlayer mediaPlayer;

        public MediaController() 
        {
            this.mediaPlayer = new System.Windows.Media.MediaPlayer();
        }

        public void setUri(Uri uri) 
        {
            throw new NotImplementedException();
        }

        public void Play() 
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Stop() 
        {
            throw new NotImplementedException();
        }
    }
}
