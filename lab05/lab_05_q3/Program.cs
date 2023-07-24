using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, choice;

            CalculateValues cal = new CalculateValues();
            

            Console.Write("Enter 1 for Addition\n" +
                "Enter 2 for Subtract\n" +
                "Enter 3 for Division\n" +
                "Enter 4 for Multiplication\n");

            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            if (choice == 1) 
            {
                Console.WriteLine("Addition: "+cal.add(n1, n2));
            }else if (choice == 2)
            {
                Console.WriteLine("Subtraction: "+ cal.subtract(n1, n2));
            }else if(choice == 3)
            {
                Console.WriteLine("Division: "+ cal.div(Convert.ToDouble(n1), Convert.ToDouble(n2)));
            }else if (choice==4)
            {
                Console.WriteLine("Multiplication: " + cal.mul(n1, n2));
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

            Console.ReadKey();
        }
    }
}
