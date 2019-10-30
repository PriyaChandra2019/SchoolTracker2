using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker1
{
    enum school
    {
        Hogwarts,
        Harvard,
        MIT 
    }

    class Program
    {
        static List<student> students = new List<student>();

        static void Main(string[] args)
        {

            var adding = true;

            while (adding)
            {
                try
                {

                    var newStudent = new student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                    newStudent.School = (school) Util.Console.AskInt("School Name (type the corresponding number):\n 0: Hogwarts High \n 1: Harvard \n 2: MIT \n)");

                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.Address = Util.Console.Ask("Student Address: ");

                    newStudent.Phone = Util.Console.AskInt("Student phone Number: ");

                    students.Add(newStudent);
                    student.Count++;
                    Console.WriteLine("Student Count: {0}", student.Count);


                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;

                }



                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, Please try again");
                }


            }

            foreach (var student in students)

            {
                Console.WriteLine("Name: {0}, Grade: {1} ", student.Name, student.Grade);
            }
            Exports();
            Console.ReadKey();
        }

        static void Import()
        {
            var importedStudent = new student("Tim", 98, "birthday", "address", 4664654);
            Console.WriteLine(importedStudent.Name);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case school.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case school.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case school.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;

                }
            }
        }

        class Member
        {
            public string Name;
            public string Address;
            protected int phone;

            public int Phone
            {
                set { phone = value; }
            }

        }


        class student : Member
        {
            static public int Count = 0;

            public int Grade;
            public string Birthday;
            public school School;



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


        }

        class Teacher : Member
        {

            public string Subject;
        }
    }
}

