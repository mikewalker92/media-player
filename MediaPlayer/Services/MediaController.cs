namespace MediaPlayer.Services

{
    using MediaPlayer.Config;
    using MediaPlayer.DataModels;
    using MediaPlayer.Exceptions;
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
        void JumpToPosition(int seconds);
        TimeSpan TrackLength { get; set; }
    }

    public class MediaController : IMediaController
    {
        private System.Windows.Media.MediaPlayer mediaPlayer;
        private IEnvironmentProperties properties;

        public MediaController(IEnvironmentProperties properties)
        {
            this.mediaPlayer = new System.Windows.Media.MediaPlayer();
            this.properties = properties;
        }

        #region Properties

        public TimeSpan TrackLength { get; set; }

        #endregion

        public void setUri(Uri uri) 
        {
            mediaPlayer.Open(uri);
            TrackLength = FindTrackLength();
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

        public void JumpToPosition(int seconds)
        {
            mediaPlayer.Position = new TimeSpan(seconds * 10 );
        }

        private TimeSpan FindTrackLength()
        {
            var retrys = 0;
            var maxRetrys = properties.MediaControllerMaxWaitForTrackLength() / properties.MediaControllerRetryDelayForTrackLength();
            while (!mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                if (retrys > maxRetrys)
                {
                    throw new InvalidMediaException("Unable to find track length");
                }
                System.Threading.Thread.Sleep(properties.MediaControllerRetryDelayForTrackLength());
            }
            return mediaPlayer.NaturalDuration.TimeSpan;
        }
    }
}
