using Bridge.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example.Concretes
{
    public class Spotify : IMusicPlayer
    {
        public string PlayMusic(Music music)
        {
            Console.WriteLine($"Spotify:{music} musiqisini seslendirir");

            return music.Volume;
        }
    }
}
