using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolymorphismClassTask.Models;

namespace PolymorphismClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("John", "Rivera", 15, 10, 120);
            Console.WriteLine(e.CalculateSalary());

            Student s = new Student("Kate", "Jacobs", 20, 10, 300);
            Console.WriteLine(s.ExamResult());

        }
    }
}
