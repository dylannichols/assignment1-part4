using System;

namespace assignment1_part4
{
    class Student : Person
    {
        public string Campus { get; set; }
        public int StudentID {get; set;}
        public Student(string campus, string FirstName, string LastName) : base(FirstName, LastName)
        {
            Campus = campus;
        }

        public int EnrollStudent()
        {
            var rand = new Random();
            return rand.Next(1000, 9999);
        }

        public override string PersonInfo()
        {
            return $"\n{FirstName} {LastName} of {Campus} campus has a student ID of {StudentID}";
        }
    }
}