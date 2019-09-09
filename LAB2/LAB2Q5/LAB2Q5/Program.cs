using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Q5
{
    class BooksDemo
    {
        static void Main(string[] args)
        {
            string[,] bookDetails = new string[2, 4];
            Console.WriteLine("Enter Book Details in order of Book Title, Author, Publisher, Price");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Details of Book"+(i+1));
                for (int j = 0; j < 4; j++)
                {
                    bookDetails[i,j]=Console.ReadLine();
                }
            }
            Console.WriteLine("Entered Book Details are:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Details of Book" + (i + 1));
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(bookDetails[i, j]+"   ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
