using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker1
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new student();

                newStudent.Name = Util.Console.Ask("Student Name: ");
                                                
                newStudent.Grade = int.Parse(Util.Console.Ask("Student Grade: "));
                                
                newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                newStudent.Address = Util.Console.Ask("Student Address: ");

                newStudent.Phone = int.Parse(Util.Console.Ask("Student phone Number: "));

                students.Add(newStudent);
                student.Count++;
                Console.WriteLine("Student Count: {0}", student.Count);


                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }


            foreach (var student in students)

            {
                Console.WriteLine("Name: {0}, Grade: {1} ", student.Name, student.Grade);
            }
            Console.ReadKey();
        }

        static void Import()
        {
            var importedStudent = new student("Tim", 98, "birthday", "address", 4664654);
            Console.WriteLine(importedStudent.Name);
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;
    }


    class student : Member
    {
        static public int Count = 0;
                
        public int Grade;
        public string Birthday;
        
       

        public student()
        {

        }

        public student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;

        
        }

        public int Phone
        {
            set { phone = value; }
        }

        public void SetPhone(int number)
        {
            phone = number;
        }



    }

    class Teacher
    {
        public string Name;
        public string Address;
        public int phone;
        public string Subject;
    }

}