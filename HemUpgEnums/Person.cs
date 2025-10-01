using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemUpgEnums
{
    internal class Person
    {
        //Props
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid age, age can't be less than 1.");
                    _age = 1;
                }
                else
                {
                    _age = value;
                }
            }
        }

        //Construktor
        public Person(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }

        //Methods
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
