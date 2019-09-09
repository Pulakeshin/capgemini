using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Q4
{
    class ProductDemo
    {
        public string productID;
        public string productName;
        public double price;
        public int quantity;
        public double amountPayable;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductDemo pro = new ProductDemo();
            
            Console.WriteLine("Enter product ID:");
            pro.productID = Console.ReadLine();
            Console.WriteLine("Enter product name:");
            pro.productName = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            pro.price =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            pro.quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product Details:");
            Console.WriteLine("Product ID: "+pro.productID);
            Console.WriteLine("Product Name: " + pro.productName);
            Console.WriteLine("Product Price: " + pro.price);
            Console.WriteLine("Product Quantity: " + pro.quantity);

            System.Object ProductID = pro.productID;
            System.Object ProductName = pro.productName;
            System.Object Price = pro.price;
            System.Object Quantity = pro.quantity;

            pro.amountPayable = Convert.ToDouble((double)Price*(int)Quantity);
            Console.WriteLine("Amount Payable : "+pro.amountPayable);

            string proID = (string)ProductID;
            string proName = (string)ProductName;
            double proPrice = (double)Price;
            int proQuantity = (int)Quantity;
        }
    }
}
