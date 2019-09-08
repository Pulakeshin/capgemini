using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABQ4
{
    class SchoolDemo
    {
        private int _rollNumber;
        private string _studentName;
        private byte _age;
        private char _gender;
        private DateTime _dateOfBirth;
        private string _address;
        private float _percentage;

        public int RollNumber { get => _rollNumber; set => _rollNumber = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public string Address { get => _address; set => _address = value; }
        public float Percentage { get => _percentage; set => _percentage = value; }
        public byte Age { get => _age; set => _age = value; }

        public SchoolDemo(int rollNumber,string studentName,byte age,char gender,DateTime dateOfBirth,string address,float percentage)
        {
            RollNumber = rollNumber;
            StudentName = studentName;
            Age = age;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Address = address;
            Percentage = percentage;

        }
        static void Main(string[] args)
        {
            SchoolDemo student = new SchoolDemo(44, "Pulak", 22, 'm', DateTime.Parse("1997-Jan-08"), "Odisha", 94);
            Console.WriteLine("Student Details :");
            Console.WriteLine("Student Roll Number : "+student.RollNumber);
            Console.WriteLine("Student Name : " + student.StudentName);
            Console.WriteLine("Student Age : " + student.Age);
            Console.WriteLine("Student Gender : " + student.Gender);
            Console.WriteLine("Student DOB : " + student.DateOfBirth);
            Console.WriteLine("Student Address : " + student.Address);
            Console.WriteLine("Student Percentage : " + student.Percentage+"%");

            Console.ReadKey();
        }

        
    }
}
