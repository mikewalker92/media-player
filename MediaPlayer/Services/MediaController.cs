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
        TimeSpan GetTrackLength();
        void JumpToPosition(int seconds);
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
            mediaPlayer.Open(uri);
        }

        public void Play() 
        {
            mediaPlayer.Play();
        }

        public void Pause()
        {
            mediaPlayer.Pause();
        }

        public void Stop() 
        {
            mediaPlayer.Stop();
        }

        public TimeSpan GetTrackLength()
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                return mediaPlayer.NaturalDuration.TimeSpan;
            }
            return new TimeSpan();
        }

        public void JumpToPosition(int seconds)
        {
            mediaPlayer.Position = new TimeSpan(seconds * 10 );
        }
    }
}
