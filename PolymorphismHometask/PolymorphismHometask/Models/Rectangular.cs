using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismHometask.Models
{
    internal class Rectangular:Figure
    {
        private double _length;
        public double Length { get { return _length; } set { if (value > 0) _length = value; else { Console.WriteLine("Length can not be negative for rectangular"); } } }
        private double _width;
        public double Width { get { return _width; } set { if (value > 0) _width = value; else { Console.WriteLine("Width can not be negative for rectangular"); } } }
        public Rectangular(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public override double CalcArea()
        {
            
            return Length * Width;
            
        }
    }
}
