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

    public class ControlPanelViewModel : Screen
    {
        private IMediaController mediaController;
        private Track _track;

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
                mediaController.setUri(new Uri(value.Uri));
            }
        }

        #endregion

        public void Play()
        {
            mediaController.Play();
        }

        public void Pause()
        {
            mediaController.Pause();
        }

        public void Stop()
        {
            mediaController.Stop();
        }
    }
}
