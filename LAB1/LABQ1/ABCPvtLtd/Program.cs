using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPvtLtd
{
    class Employee
    {
        private string _empID;
        private string _empName;
        private string _address;
        private string _city;
        private string _department;
        private double _salary;
        
        public string EmpID
        {
            set
            {
                _empID = value;
            }
            get
            {
                return _empID;
            }
        }
        public string EmpName
        {
            set
            {
                _empName = value;
            }
            get
            {
                return _empName;
            }
        }
        public string Address
        {
            set
            {
                _address = value;
            }
            get
            {
                return _address;
            }
        }
        public string City
        {
            set
            {
                _city = value;
            }
            get
            {
                return _city;
            }
        }
        public string Department
        {
            set
            {
                _department = value;
            }
            get
            {
                return _department;
            }
        }
        public double Salary
        {
            set
            {
                _salary = value;
            }
            get
            {
                return _salary;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Employee[] employee = new Employee[10];
            for (int i = 1; i <= 10; i++)
            {
                employee[i] = new Employee();
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter details for Employee " +i);
                Console.WriteLine("Enter the Employee ID :");
                employee[i].EmpID = Console.ReadLine();
                Console.WriteLine("Enter the Employee Name :");
                employee[i].EmpName = Console.ReadLine();
                Console.WriteLine("Enter the Employee Address :");
                employee[i].Address = Console.ReadLine();
                Console.WriteLine("Enter the Employee City :");
                employee[i].City = Console.ReadLine();
                Console.WriteLine("Enter the Employee Department :");
                employee[i].Department = Console.ReadLine();
                Console.WriteLine("Enter the Employee Salary :");
                employee[i].Salary = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Employee Name & Salary of Employee "+i+" :");
                Console.WriteLine(employee[i].EmpName + "  "+employee[i].Salary);
            }

            

            Console.ReadKey();
        }
    }
}
