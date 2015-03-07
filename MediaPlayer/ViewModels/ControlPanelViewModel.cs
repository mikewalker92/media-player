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
    using MediaPlayer.Helpers;

    public class ControlPanelViewModel : Screen
    {
        private IMediaController mediaController;
        private Track _track;
        private string _playPauseButtonContent = "Play";
        private string _trackLength;
        private int _trackPosition;

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
                SetTrackLength();
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
                if (value == _trackLength)
                {
                    return;
                }
                _trackLength = value;
                NotifyOfPropertyChange(() => TrackLength);
            }
        }

        public int TrackPosition
        {
            get
            {
                return _trackPosition;
            }
            set
            {
                if (value == _trackPosition)
                {
                    return;
                }
                _trackPosition = value;
                NotifyOfPropertyChange(() => TrackPosition);
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

        public void DragCompleted(double position)
        {
            JumpTrackToPosition(position);
        }

        public void ClickToNewTrackPosition(double position)
        {
            JumpTrackToPosition(position);
        }

        private void JumpTrackToPosition(double position)
        {
            mediaController.JumpToPosition((int)position);
        }

        private void SetTrackLength()
        {
            var timeSpan = mediaController.GetTrackLength();
            TrackLength = timeSpan.ToMinsSecsFormat();
        }
    }
}
