using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Project3
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables//
            string AreaCalc;
            double radiusInput;
            const double radius = 3.14d;
            double TotalArea;

            //Codes//
            Console.WriteLine("\"Welcome to Program3\"");
            Console.WriteLine();
            Console.WriteLine("Insert Radius");
            Console.WriteLine();
            AreaCalc = Console.ReadLine();
            radiusInput = Convert.ToDouble(AreaCalc);
            TotalArea = radius * radiusInput * radiusInput;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("The Area of radius {0} is {1}", radiusInput, TotalArea);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
