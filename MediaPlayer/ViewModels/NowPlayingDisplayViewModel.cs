namespace MediaPlayer.ViewModels

{
    using Caliburn.Micro;
    using MediaPlayer.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NowPlayingDisplayViewModel : TrackViewModel
    {
        private IImageSourceFactory imageSourceFactory;

        public NowPlayingDisplayViewModel(IImageSourceFactory imageSourceFactory) : base(imageSourceFactory) { }
    }
}
