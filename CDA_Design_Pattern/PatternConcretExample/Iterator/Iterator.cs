using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public interface Iterator
    {
        public bool HasMore();
        public void GetNext();
        public Trainee GetCurrent();
    }
}