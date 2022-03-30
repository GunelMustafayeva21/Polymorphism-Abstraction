using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismClassTask.Models
{
    public class Employee:Person
    {

        public double MoneyForOneHour;
        public double WorkingHourForMonth;
        public override int Age { get; set; }
        public Employee(string Name, string Surname, int Age, double MoneyForOneHour, double WorkingHourForMonth):base(Name, Surname)
        {
            this.Age = Age;
            this.MoneyForOneHour = MoneyForOneHour;
            this.WorkingHourForMonth = WorkingHourForMonth;
        }
        public double  CalculateSalary()
        {
            if (Age >= 18) {
                // Ayı 30 gün götürmüşəm bir günə neçə saat işlədiyini tapmaq üçün  bir aylıq işləmə saatını 30 böldüm
                if (WorkingHourForMonth / 30 <= 8)
                {
                    if (WorkingHourForMonth * MoneyForOneHour >= 250)
                    {
                        return WorkingHourForMonth * MoneyForOneHour;
                    }
                    else { Console.WriteLine("Maas 250 Azndan azdir"); return 0; }
                }

                else { Console.WriteLine("Is saati coxdur"); return 0; }
                }
            else { Console.WriteLine("Isleme huququ yoxdur");
                return 0;
            }
        }
    }
}
