using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolKit
{
    abstract class Kit
    {
        private int volume = 50;
        private bool isOpened = true;

        public Kit(int _volume)
        {
            Volume = _volume;
        }

        public void Open()
        {
            if(!IsOpened)
            IsOpened = true;
            else Console.WriteLine("schoolkit is already opened");
        }

        public void Close()
        {
            if(IsOpened)
            IsOpened = false;
            else Console.WriteLine("schoolkit is already closed");
        }

        public int Volume
        {
            get => volume; 
            set => volume = value; 
        }

        public bool IsOpened
        {
            get => isOpened; 
            private set => isOpened = value;
        }
        
    }
}