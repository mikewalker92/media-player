namespace MediaPlayer.Config

{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEnvironmentProperties
    {
        int MediaControllerMaxWaitForTrackLength();
        int MediaControllerRetryDelayForTrackLength();
    }

    public class EnvironmentProperties : IEnvironmentProperties
    {
        public int MediaControllerMaxWaitForTrackLength()
        {
            return Properties.Settings.Default.mediaController_trackLength_maxWaitMillis;
        }

        public int MediaControllerRetryDelayForTrackLength()
        {
            return Properties.Settings.Default.mediaController_trackLength_retryDelayMillis;
        }
    }
}
