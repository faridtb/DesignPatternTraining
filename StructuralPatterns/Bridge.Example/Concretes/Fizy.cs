using Bridge.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example.Concretes
{
    internal class Fizy : IMusicPlayer
    {
        public string PlayMusic(Music music)
        {
            Console.WriteLine($"Fizy:{music} musiqisini seslendirir");

            return music.Volume;
        }
    }
}
