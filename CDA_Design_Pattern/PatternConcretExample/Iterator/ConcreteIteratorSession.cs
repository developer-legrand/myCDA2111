using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public abstract class ConcreteIteratorSession : Iterator
    {
        private int index;
        private ConcreteIterableSession collection;

        public ConcreteIteratorSession(ConcreteIterableSession collection)
        {
            this.collection = collection;
        }

        public Trainee GetCurrent()
        {
            throw new NotImplementedException();
        }

        public void GetNext()
        {
            index++;
        }

        public bool HasMore()
        {
            return true;
           
        }
    }
}