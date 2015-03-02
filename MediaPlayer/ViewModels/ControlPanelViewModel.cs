namespace MediaPlayer.ViewModels

{
    using Caliburn.Micro;
    using MediaPlayer.DataModels;
    using MediaPlayer.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Controls;

    public class ControlPanelViewModel : Screen
    {
        private IMediaController mediaController;
        private Track _track;
        private string _playPauseButtonContent = "Play";
        private string _trackLength;

        public ControlPanelViewModel(IMediaController mediaController) 
        {
            this.mediaController = mediaController;
        }

        #region Properties

        public Track Track
        {
            private get 
            {
                return _track;
            }
            set
            {
                _track = value;
                if (value.Uri != null)
                {
                    mediaController.setUri(new Uri(value.Uri));
                }
                TrackLength = mediaController.TrackLength();
            }
        }

        public String PlayPauseButtonContent
        {
            get
            {
                return _playPauseButtonContent;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                _playPauseButtonContent = value;
                NotifyOfPropertyChange(() => PlayPauseButtonContent);
            }
        }

        public String TrackLength
        {
            get
            {
                return _trackLength;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                _trackLength = value;
                NotifyOfPropertyChange(() => TrackLength);
            }
        }

        #endregion

        public void PlayOrPause()
        {
            if (PlayPauseButtonContent == "Play")
            {
                mediaController.Play();
                PlayPauseButtonContent = "Pause";
            }
            else if (PlayPauseButtonContent == "Pause")
            {
                mediaController.Pause();
                PlayPauseButtonContent = "Play";
            }
            
        }

        public void Stop()
        {
            mediaController.Stop();
        }
    }
}
