using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchPerson
{
    class Person
    {
        private string _firstName;
        private Watch _watch;
     
        public Person(string _firstName)
        {
            this.FirstName = _firstName;
            this.WatchWorn = null;
        }

        public string FirstName
        {
            get => _firstName;
            private set => _firstName = value;
        }
      
        public Watch WatchWorn
        {
            get => _watch;
            private set => _watch= value;
        }
        /// <summary>
        /// Mettre une montre à une personne si elle n'en a pas déjà une.
        /// </summary>
        /// <param name="_watch"></param>
        public void PutWatch(Watch _watch)
        {
            if (WatchWorn == null && _watch.PersonGetThisWatch == null)
            {
                this.WatchWorn = _watch;
                _watch.PersonGetThisWatch = this;
                Console.WriteLine($"{FirstName} wear a {_watch.WatchMark}");
            }
            else
            {
                Console.WriteLine($"{FirstName} already wear a {_watch.WatchMark}");
            }
          
        }
        /// <summary>
        /// Retirer la montre si une personne en a une.
        /// </summary>
        public void RemoveWatch()
        {
            if (this.WatchWorn != null)
            {
                this.WatchWorn.PersonGetThisWatch = null;
                this.WatchWorn = null;
            }
           
        }
        public string AskHourTo(Person _otherPerson)
        {
            if (_otherPerson.WatchWorn != null)
            {
                return _otherPerson.WatchWorn.PrintHour();
            }
            else
            {
                return $"{_otherPerson.FirstName} doesn't have a watch";
            }
        }
    }
}
