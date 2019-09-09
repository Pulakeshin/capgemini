using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Q1
{
    struct temp
    {
        public int number;
    }
    class Program
    {
        static void Main(string[] args)
        {
            temp n = new temp();
            Console.WriteLine("Enter a number :");
            n.number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for square and 2 for cube:");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x==1)
            {
                Square();
            }
            else if (x==2)
            {
                Cube();
            }
            else
            {
                Console.WriteLine("Invalid Input!!!");
            }
            void Square()
            {
                Console.WriteLine("Square of "+n.number+" is "+((n.number)* (n.number)));
            }
            void Cube()
            {
                Console.WriteLine("Cube of " + n.number + " is " + ((n.number) * (n.number) * (n.number)));
            }
        }
    }
}
