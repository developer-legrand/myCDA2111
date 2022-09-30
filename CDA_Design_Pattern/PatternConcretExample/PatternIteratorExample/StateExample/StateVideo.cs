using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public interface StateVideo
    {
        public StateVideo Play(Video v);
        public StateVideo Stop(Video v);
    }
}