using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 6];
            Console.WriteLine("Enter the values in the array:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter next row: "+(i+1));
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Entered array is :");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
