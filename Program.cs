using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
   

    class Program
    {
        static Student GetStudent()
        {
            var student = new Student();

            student.firstName = "Nikita";
            student.middleName = "Sergeevich";
            student.lastName = "Nikiforov";
            student.age = 35;
            student.id = Guid.NewGuid();
            student.group = "Engeneer";

            return student;
        }
        
        public static void Print(Student student)
        {
            Console.WriteLine("Student's info: ");
            Console.WriteLine($"Id: {student.id}");
            Console.WriteLine($"LastName: {student.lastName}");
            Console.WriteLine($"Name: {student.firstName}");
            Console.WriteLine($"MiddleName: {student.middleName}");
            Console.WriteLine($"Age: {student.age}");
            Console.WriteLine($"Group: {student.group}");
        }

        static void Main(string[] args) 
        {
            var firstStudent = GetStudent();

            Print(firstStudent);
        }


    }
}