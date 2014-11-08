
namespace MediaPlayer.Core.Tests
{
    using NUnit.Framework;
    using FluentAssertions;
    using FakeItEasy;
    using System.Windows.Controls;
    using MediaPlayer.Core;
    
    [TestFixture]
    public class SongTests
    {
    	private Song song;
    	
    	[SetUp]
    	public void SetUp()
    	{
    		song = new Song();
    	}
    	
    	[Test]
    	public void Number_of_plays_increases_by_one_when_song_is_played()
    	{
    		// When
            song.Play();

            // Then
            song.NumberOfPlays.Should().Be(1);
    	}
    }
}
