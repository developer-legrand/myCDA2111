using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class AgeIterator : ConcreteIteratorSession
    {
        public AgeIterator(ConcreteIterableSession collection) : base(collection)
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