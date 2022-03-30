using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismClassTask.Models
{
    public class Student : Person
    {
        private int _iqrank;
        public int Iqrank { get { return _iqrank; } set { if (value > 0 && value <= 100) _iqrank = value; else { Console.WriteLine("Invalid input for Iqrank "); } } }
        private int _iqlanguage;
        public int Iqlanguage { get { return _iqlanguage; } set { if (value > 0 && value <= 100) _iqlanguage = value; else { Console.WriteLine("Invalid input for Iqlanguage "); } } }
        private int _age;
        public override int Age
        {
            get { return _age; }
            set { if (value >= 6 && value <= 20) _age = value; else { Console.WriteLine("Invalid input for student age"); } }

        }

        public Student(string Name, string Surname, int Age, int Iqrank, int Iqlanguage) : base(Name, Surname)
        {
            this.Age = Age;
            this.Iqrank = Iqrank;
            this.Iqlanguage = Iqlanguage;
        }

        public string ExamResult()
        {
            if (Age >= 6 && Age <= 20)
            {
                if (Iqrank + Iqlanguage >= 120) { return "Passed"; }
                else { return "Failed"; }
            }
            else { return "Daxil edilen yas telebenin yas intervalina uygun deyil"; }
        }
    }
}
