using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class ConcreteIterableSession : Iterablecollection
    {
        private List<Trainee> trainees;

        public Iterator CreateIterator()
        {
            return new DefaultIterator(this);
        }

        public void AddTrainee(Trainee t)
        {
            trainees.Add(t);
        }

        public Trainee this[int index]
        {
            get { return trainees[index]; }
        }

        

    }
}