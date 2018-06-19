using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in the amount of currency in order to see how much the VAT will be: ");
            var Number = Console.ReadLine();

            double Currency = int.Parse(Number) + (int.Parse(Number) * 0.25);
            Console.WriteLine("The Currency with VAT is: " + Currency);

            Console.WriteLine();
            Console.WriteLine("Press any button to exit...");
            Console.ReadLine();
        }
    }
}
