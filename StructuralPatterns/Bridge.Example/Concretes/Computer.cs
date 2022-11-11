using Bridge.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example.Concretes
{
    public class Computer : Device
    {
        public Computer(ISpeaker speaker, IMusicPlayer player) : base(speaker, player)
        {
        }

        public override void PlayMusic(Music music)
        {
            Console.WriteLine("Komputer ishledi");
            base.PlayMusic(music); 
        }
    }
}
