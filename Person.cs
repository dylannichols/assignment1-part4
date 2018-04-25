using System;

namespace assignment1_part4
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetAge()
        {

            return DateTime.Now.Year - YearOfBirth;
        }

        public virtual string PersonInfo()
        {
            return $"\nPerson: {GetFullName()} is {GetAge()} years old";
        }
    }
}