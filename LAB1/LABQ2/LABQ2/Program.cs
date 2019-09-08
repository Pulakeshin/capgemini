using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABQ2
{
    class ArithmeticOperations
    {
        static void Main()
        {
            double x, y, temp;
            Console.Write("Enter the first number :");
            x=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number :");
            y = Convert.ToDouble(Console.ReadLine());

            void Add()
            {
                Console.WriteLine("Addition of " + x+" & " + y +" = " + (x+y));
            }
            void Subtract()
            {
                Console.WriteLine("Subtraction of " + x + " & " + y + " = " + (x - y));
            }
            void Multiply()
            {
                Console.WriteLine("Multiplication of " + x + " & " + y + " = " + (x * y));
            }
            void Divide()
            {
                Console.WriteLine("Division of " + x + " & " + y + " = " + (x / y));
            }
            void Modulus()
            {
                Console.WriteLine("Modulus of " + x + " & " + y + " = " + (x % y));
            }

            Console.WriteLine("Enter the Arithmetic Operation to perform (1-5)");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Modulus");

            temp=Convert.ToDouble(Console.ReadLine());

            switch (temp)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Multiply();
                    break;
                case 4:
                    Divide();
                    break;
                case 5:
                    Modulus();
                    break;
                default:
                    Console.WriteLine("Invalid Selection !!!");
                    break;
            }

            Console.ReadKey();

        }
    }
}
