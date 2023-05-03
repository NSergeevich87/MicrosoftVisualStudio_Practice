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
        static void Main(string[] args) 
        {
            var firstStudent = GetStudent();
            firstStudent.Print();

            string fullName = firstStudent.GetFullName();   
        }
    }
}