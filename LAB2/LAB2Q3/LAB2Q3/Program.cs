using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] city = new string[4];
            Console.WriteLine("Enter city names :");
            for (int i = 0; i < 4; i++)
            {
                city[i] = Console.ReadLine();
            }
            Console.WriteLine("Entered cities are :");
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(city[j]);
            }
            Console.ReadKey();
        }
    }
}
