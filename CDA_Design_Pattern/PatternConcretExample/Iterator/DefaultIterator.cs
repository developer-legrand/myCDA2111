using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class DefaultIterator : ConcreteIteratorSession 

    {
        public DefaultIterator(ConcreteIterableSession collection) : base(collection)
        {
        }

        public Trainee GetCurrent()
        {
            throw new NotImplementedException();
        }

        public void GoToNext()
        {
            throw new NotImplementedException();
        }

        public bool HasMore()
        {
            throw new NotImplementedException();
        }
    }
}