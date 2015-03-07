namespace MediaPlayer.Helpers

{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class TimeSpanExtensions
    {
        public static String ToMinsSecsFormat(this TimeSpan timespan)
        {
            var mins = timespan.Minutes;
            var secs = timespan.Seconds;
            if (secs < 10)
            {
                return String.Format("{0}:0{1}", mins, secs);
            }
            return String.Format("{0}:{1}", mins, secs);
        }
    }
}
