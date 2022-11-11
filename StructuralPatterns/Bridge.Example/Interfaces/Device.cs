using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Example.Concretes;

namespace Bridge.Example.Interfaces
{
    public abstract class Device
    {
        protected ISpeaker speaker;
        protected IMusicPlayer player;

        public Device()
        {

        }

        protected Device(ISpeaker speaker, IMusicPlayer player)
        {
            this.speaker = speaker;
            this.player = player;
        }

        public virtual void PlayMusic(Music music)
        {
            var str = player.PlayMusic(music);
            speaker.VolumeSound(str);
        }
    }
}
