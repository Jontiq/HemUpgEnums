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
        private string _firstName;
        public string FirstName 
        {
            get 
            {
                return _firstName;
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid first name, cannot be null or whitespace.");
                    _firstName = "Unknown";
                }
                else
                {
                    _firstName = value;
                }
            } 
        }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid last name, cannot be null or whitespace.");
                    _lastName = "Unknown";
                }
                else
                {
                    _lastName = value;
                }
            }
        }
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
