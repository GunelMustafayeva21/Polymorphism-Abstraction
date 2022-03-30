using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismHometask.Models
{
    public class Square:Figure
    {
        private double _side;
        public double Side { get { return _side; } set { if (value > 0) _side = value; else { Console.WriteLine("Side can not be negative for Square"); } } }
        public Square(double Side)
        {
            this.Side = Side;
        }
        public override double CalcArea()
        {
            return Side * Side;
        }
    }
}
