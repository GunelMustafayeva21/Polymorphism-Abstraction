using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismClassTask.Models
{
    public abstract  class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract int Age { get; set; }

        

        public Person()
        {

        }
        public Person(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
    }
}
