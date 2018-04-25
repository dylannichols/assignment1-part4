using System;

namespace assignment1_part4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of new student below");
            Console.Write("Enter first name: ");
            var fname = Console.ReadLine();
            Console.Write("Enter last name: ");
            var lname = Console.ReadLine();
            Console.Write("Enter campus: ");
            var campus = Console.ReadLine();

            Console.WriteLine("\nCreating a new person record...");
            var student = new Student(campus, fname, lname);
            Console.WriteLine($"\nAdding new student record to {student.Campus} campus...");
            student.StudentID = student.EnrollStudent();

            Console.WriteLine(student.PersonInfo());
        }
    }
}
