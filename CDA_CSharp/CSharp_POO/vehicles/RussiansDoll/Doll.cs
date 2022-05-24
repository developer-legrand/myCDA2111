using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiansDoll
{
    class Doll
    {
        private int _size;
        private string _nameDoll;
        private bool _isOpen;
        
        private bool _removeOrAdd;
      

        private Doll _upperDoll;
        private Doll _lowerDoll;

        public Doll(int size, string nameDoll, Doll upperDoll, Doll lowerDoll)
        {
            this.NameDoll = nameDoll;
            this.Size = size;
            this.IsOpen = false;
            this.UpperDoll = null;
            this.LowerDoll = null;
        }

        public Doll UpperDoll
        {
            get { return _upperDoll; }
            set { _upperDoll = value; }
        }

        public Doll LowerDoll
        {
            get { return _lowerDoll; }
            set { _lowerDoll = value; }
        }

        public string NameDoll
        {
            get { return _nameDoll; }
            set { _nameDoll = value; }
        }

        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }

        public int Size
        {
            get { return _size; }
            init { _size = value; }
        }


        public bool IsSmallerThan(Doll _dollToCompare)
        {
            if (Size < _dollToCompare.Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Open()
        {
            if (!IsOpen && UpperDoll == null)
            {
                Console.WriteLine($"open {NameDoll}");
                this.IsOpen = true; 
            }
            else 
            {
                Console.WriteLine($"{NameDoll} already opened");
            }
        }

        public void Close()
        {
            if (IsOpen)
            {
                Console.WriteLine($"close {NameDoll}");
                this.IsOpen = false;
            }
            else
            {
                Console.WriteLine($"{NameDoll} already closed");
            }
        }

        public void PlaceDollIn(Doll _placeInUpperDoll)
        {
            if(UpperDoll == null)
            {
                if (_placeInUpperDoll.UpperDoll == null)
                {
                    if (IsSmallerThan(_placeInUpperDoll))
                    {
                        if (_placeInUpperDoll.LowerDoll == null)
                        {
                            if(this != _placeInUpperDoll.LowerDoll)
                            {
                                do
                                {
                                    if (!_placeInUpperDoll.IsOpen)
                                    {
                                        _placeInUpperDoll.Open();
                                    }
                                    else
                                    {
                                        _removeOrAdd = false;
                                    }
                                }
                                while (_removeOrAdd);
                                UpperDoll = _placeInUpperDoll;
                                _placeInUpperDoll.LowerDoll = this;
                                Console.WriteLine($"add {NameDoll} in {_placeInUpperDoll.NameDoll}");
                                _placeInUpperDoll.Close();
                            }
                            else
                            {
                                Console.WriteLine($" {NameDoll} is already in {_placeInUpperDoll.NameDoll}");
                            }
                       
                        }
                        else
                        {
                            Console.WriteLine($"{_placeInUpperDoll.NameDoll} is not empty");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{NameDoll} is bigger than {_placeInUpperDoll.NameDoll} can't be inside");
                    }
                }
                else
                {
                    Console.WriteLine($"{_placeInUpperDoll.NameDoll} is already in another one");
                }
            }
            else
            {
                Console.WriteLine($"{NameDoll} is already in another one");
            }
        }

        public void RemoveDollIn(Doll _removeInUpperDoll)
        {
            if(UpperDoll == null)
            { 
                if (UpperDoll != _removeInUpperDoll.LowerDoll)
                {
                    if (_removeInUpperDoll.UpperDoll != null)
                    {
                        if (_removeInUpperDoll.LowerDoll == null)
                        {
                                do
                                {
                                    if (!_removeInUpperDoll.IsOpen)
                                    {
                                        _removeInUpperDoll.Open();
                                    }
                                    else
                                    {
                                        _removeOrAdd = false;
                                    }
                                }
                                while (_removeOrAdd);
                                /*this.UpperDoll = null;*/
                                _removeInUpperDoll.LowerDoll = null;
                                Console.WriteLine($"remove {NameDoll} from {_removeInUpperDoll.NameDoll}");
                                _removeInUpperDoll.Close();

                        }
                        else
                        {
                            Console.WriteLine($"{_removeInUpperDoll.NameDoll} is empty");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{_removeInUpperDoll.NameDoll} is in another");
                    }
                }
                else
                {
                    Console.WriteLine($"{NameDoll} is in another");
                }
            }
            else
            {
                Console.WriteLine($"{NameDoll} is not in another doll ");
            }
              
        }
    }
}
