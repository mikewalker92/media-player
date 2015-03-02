namespace MediaPlayerTests.ViewModelTests
{
    using FakeItEasy;
    using FluentAssertions;
    using MediaPlayer.DataModels;
    using MediaPlayer.Services;
    using MediaPlayer.ViewModels;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class ControlPanelViewModelTests
    {
        private ControlPanelViewModel model;
        private IMediaController mediaController;
        private const string FILEPATH = "file://path/to/file";

        [SetUp]
        public void SetUp()
        {
            mediaController = A.Fake<IMediaController>();
            model = new ControlPanelViewModel(mediaController);
        }

        [Test]
        public void NewTackSet_setsUri()
        {
            // Given
            var track = new Track { Uri = FILEPATH };

            // When
            model.Track = track;

            // Them
            A.CallTo(() => mediaController.setUri(A<Uri>._)).MustHaveHappened();
        }

        [Test]
        public void TrackLoaded_play_playsTrackAndChangesButtonToPause()
        {
            // Given
            var track = new Track { Uri = FILEPATH };
            model.Track = track;

            // When
            model.PlayOrPause();
            var buttonContent = model.PlayPauseButtonContent;

            // Then
            buttonContent.Should().Be("Pause");
            A.CallTo(() => mediaController.Play()).MustHaveHappened();
        }

        [Test]
        public void TrackPlaying_pause_pausesTrackAndSetsButtonContentToPlay()
        {
            // Given
            var track = new Track { Uri = FILEPATH };
            model.Track = track;
            model.PlayOrPause();

            // When
            model.PlayOrPause();
            var buttonContent = model.PlayPauseButtonContent;

            // Then
            buttonContent.Should().Be("Play");
            A.CallTo(() => mediaController.Pause()).MustHaveHappened();
        }
    }
}
