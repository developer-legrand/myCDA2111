using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Iterator
{
    public class Trainee
    {
        private string firstName;
        private string lastName;
        private uint age;
        private string gender;

        public string Gender { get => gender; set => gender = value; }
        public uint Age { get => age; set => age = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }

        public Trainee(string lastname, uint age, string gender)
        {
            FirstName = firstName;
            LastName = lastname;
            Age = age;
            Gender = gender;
        }

    }


}