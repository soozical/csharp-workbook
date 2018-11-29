using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            students.Add(new Student("Chris", "512-385-3859", "123 That Ln", -2990));
            students.Add(new Student("Jenny", "512-304-5869", "456 Oh no", 200));
            students.Add(new Student ("Kevin", "844-567-9086", "678 Turtle Ave", 0));
            students.Add(new Student ("Luke", "475-274-3846", "890 Dog Place", -300));


            var negativeTuition = from currentStudent in students
                where currentStudent.Balance < 0
                select currentStudent.Name;

            Console.WriteLine("Students with negative Tuition:");
            foreach(string currentStudent in negativeTuition)
            {
                Console.WriteLine(currentStudent);
            }

        }
    }

    public class Student
    {
        public string Name {get; set;}
        public string Phone {get; set;}
        public string Address {get; set;}
        public int Balance {get; set;}

        public Student(string name, string phone, string address, int balance)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Balance = balance;
        }
    }



}
