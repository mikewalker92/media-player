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
        private int _trackPosition;
        private TimeSpan _trackDuration;

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
                    TrackDuration = mediaController.TrackLength;
                }
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

        public TimeSpan TrackDuration
        {
            get
            {
                return _trackDuration;
            }
            set
            {
                if (value == _trackDuration)
                {
                    return;
                }
                _trackDuration = value;
                NotifyOfPropertyChange(() => TrackDuration);
                NotifyOfPropertyChange(() => FormattedTrackDuration);
                NotifyOfPropertyChange(() => TrackDurationSeconds);
            }
        }

        public String FormattedTrackDuration
        {
            get
            {
                return _trackDuration.ToMinsSecsFormat();
            }
        }

        public int TrackDurationSeconds
        {
            get
            {
                return (int)_trackDuration.TotalSeconds;
            }
        }

        public int TrackPositionSeconds
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
                NotifyOfPropertyChange(() => TrackPositionSeconds);
                NotifyOfPropertyChange(() => FormattedTrackPosition);
            }
        }

        public String FormattedTrackPosition
        {
            get
            {
                return SecondsToMinsSecsFormat(_trackPosition);
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

        private string SecondsToMinsSecsFormat(int seconds)
        {
            var mins = seconds / 60;
            var secs = seconds % 60;
            if (secs < 10)
            {
                return String.Format("{0}:0{1}", mins, secs);
            }
            return String.Format("{0}:{1}", mins, secs);
        }
    }
}
