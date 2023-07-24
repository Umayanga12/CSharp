using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmTom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object creation
            ConvertValues convert = new ConvertValues();

            //Getting meter value from the user
            Console.WriteLine("Enter Your distance in kilometer: ");
            float km = (float) Convert.ToDecimal(Console.ReadLine());

            float meter = convert.KilometerTometer(km);
            Console.WriteLine("Your distance in Kilometer is: " + meter);


            Console.ReadKey();
        }
    }
}
