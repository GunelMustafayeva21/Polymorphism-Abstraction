using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolymorphismHometask.Models;

namespace PolymorphismHometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            //Console.WriteLine("Enter Side of Square");
            //double Side=Convert.ToDouble(Console.ReadLine());
            //Square square = new Square(Side);

            //Console.WriteLine("Enter Length of Rectangular");
            //double Length = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Length of Rectangular");
            //double Width = Convert.ToDouble(Console.ReadLine());

            //Rectangular rectangular = new Rectangular(Length, Width);

            Console.WriteLine("1---For Calculation of Square Area");
            Console.WriteLine("2---Calculation of Rectangular Area");
            Console.WriteLine("0---For Quit Progrm");

            Start:
            int number = Convert.ToInt32(Console.ReadLine());
            while (number == 1 || number == 2 || number == 0)
            {
                if (number == 1)
                {
                    Console.WriteLine("Enter Side of Square");
                    double Side = Convert.ToDouble(Console.ReadLine());
                    Square square = new Square(Side);
                    Console.WriteLine(square.CalcArea());
                    break;
                }
                if (number == 2)
                {
                    Console.WriteLine("Enter Length of Rectangular");
                    double Length = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Width of Rectangular");
                    double Width = Convert.ToDouble(Console.ReadLine());

                    Rectangular rectangular = new Rectangular(Length, Width);
                    Console.WriteLine(rectangular.CalcArea());
                    break;
                }
                if (number == 0)
                {
                    return;
                }
            }
            goto Start;
            
            
        }
    }
}
