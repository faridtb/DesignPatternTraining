using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Example.Concretes;

namespace Bridge.Example.Interfaces
{
    public interface IMusicPlayer
    {
        public string PlayMusic(Music music);
    }
}
