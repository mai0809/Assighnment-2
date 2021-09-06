using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the amount of cel:");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kelvin={0}", celsius + 273);
            Console.WriteLine("Farenheit={0}", celsius *18/10+32);

        }
    }
}
