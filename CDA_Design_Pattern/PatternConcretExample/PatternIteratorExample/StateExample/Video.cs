using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class Video
    {
        private StateVideo state;

        public Video(StateVideo state)
        {
            this.state = state;     
        }

        public void Play()
        {
            state = state.Play(this);   
        }

        public void Stop()
        {
            state = state.Stop(this);
        }
    }
}