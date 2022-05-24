using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchPerson
{
    class Watch
    {
        private string _watchMark;
        private int _hour;
        private int _minute;
        private Person _personGetThisWatch;

        public Watch(int _hour, int _minute, string _watchMark)
        {
            this.Hour = _hour;
            this.Minute = _minute;
            this.WatchMark = _watchMark;
            this.PersonGetThisWatch = null;
        }

        public Watch(Watch _clonedWatch)
        {
            /* this.ClonedWatch = _clonedWatch;*/
            this.Hour = _clonedWatch.Hour;
            this.Minute = _clonedWatch.Minute;
            this.PersonGetThisWatch = null;
        }

        public int Hour
        {
            get => _hour;
            private set
            {
                {
                    _hour = (value >= 0 && value <= 23) ? value : 0; //setter if ternaire
                }
            }
        }

        public string WatchMark
        {
            get => _watchMark;
            private set => _watchMark = value;
        }

        public Person PersonGetThisWatch
        {
            get => this._personGetThisWatch;
            set 
            {
                if (value != null && this._personGetThisWatch == null)
                {
                    this._personGetThisWatch = value;
                }
                else if (value == null && this._personGetThisWatch != null)
                {
                    this._personGetThisWatch = value;
                }
            }
        }

        public int Minute
        {
            get { return _minute; }
            private set
            {
                if (value >= 0 && value <= 59)
                    _minute = value;
                else if (value > 59)
                {
                    this.Hour++;
                    _minute = 0;
                }
                else
                {
                    _minute = 0;
                }
            }

        }

        public void AddTime()
        {
            this.Minute++;
        }

        public string PrintHour()
        {
            return $"{this.Hour:D2}H{this.Minute:D2}";
        }
    }
}
