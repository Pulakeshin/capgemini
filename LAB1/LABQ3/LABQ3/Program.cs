using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Enter a number between 1 and 5 :");
            temp = Convert.ToInt32(Console.ReadLine());
            switch (temp)
            {
                case 1:
                    Console.WriteLine("You entered number "+temp);
                    break;
                case 2:
                    Console.WriteLine("You entered number " + temp);
                    break;
                case 3:
                    Console.WriteLine("You entered number " + temp);
                    break;
                case 4:
                    Console.WriteLine("You entered number " + temp);
                    break;
                case 5:
                    Console.WriteLine("You entered number " + temp); 
                    break;
                default:
                    Console.WriteLine("Invalid Selection !!!");
                    break;
            }
        }
    }
}
