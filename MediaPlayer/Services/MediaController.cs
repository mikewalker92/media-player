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
        string TrackLength();
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

        public string TrackLength()
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                var mins = mediaPlayer.NaturalDuration.TimeSpan.Minutes;
                var secs = mediaPlayer.NaturalDuration.TimeSpan.Seconds;
                return String.Format("{0}:{1}", mins, secs);
            }
            return "NA";
        }
    }
}
