namespace MediaPlayerTests.Helpers

{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MediaPlayer.Helpers;
    using FluentAssertions;
    
    [TestFixture]
    public class TimeSpanExtensionsTests
    {
        [Test]
        public void DoubleDidgitMinsAndSecs_toMinsAndSecsFormat_returnsCorrectlyFormattedString()
        {
            var timeSpan = new TimeSpan(0, 12, 15);

            var formattedString = timeSpan.ToMinsSecsFormat();

            formattedString.Should().Be("12:15");
        }

        [Test]
        public void SingleDidgetMins_toMinsAndSecsFormat_returnsSingleDidgitMins()
        {
            var timeSpan = new TimeSpan(0, 5, 15);

            var formattedString = timeSpan.ToMinsSecsFormat();

            formattedString.Should().Be("5:15");
        }

        [Test]
        public void SingleDidgetSecs_toMinsAndSecsFormat_returnsDoubleDidgitSecs()
        {
            var timeSpan = new TimeSpan(0, 12, 5);

            var formattedString = timeSpan.ToMinsSecsFormat();

            formattedString.Should().Be("12:05");
        }

        [Test]
        public void ZeroMinsAndSec_toMinsAndSecsFormat_returnsCorrectlyFormattedString()
        {
            var timeSpan = new TimeSpan(0, 0, 0);

            var formattedString = timeSpan.ToMinsSecsFormat();

            formattedString.Should().Be("0:00");
        }
    }
}
