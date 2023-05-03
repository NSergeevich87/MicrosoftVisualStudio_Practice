using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine("Student's info: ");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"LastName: {lastName}");
            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"MiddleName: {middleName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }

        public string GetFullName()
        {
            return $"{lastName} {firstName} {middleName}";
        }
    }
}
