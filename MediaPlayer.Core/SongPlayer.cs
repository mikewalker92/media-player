using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MediaPlayer.Core
{
    public interface ISongPlayer
    {
        void Play(string fileLocation);
    }

    // TODO Ensure only one SongPlayer is ever made in the bootstrapper. 
    public class SongPlayer : ISongPlayer
    {
        public void Play(string fileLocation)
        {
            using (var soundPlayer = new SoundPlayer(fileLocation)) 
            {
                soundPlayer.Play();
            }
        }
    }
}
