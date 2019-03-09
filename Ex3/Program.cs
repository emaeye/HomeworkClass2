using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Student
    {
        public string Name;
        public string Academy;
        public string Group;
        public Student(String N, String A, String G) {
            Name = N;
            Academy = A;
            Group = G;
        }      
    }


    class Program
    {
        static void Main(string[] args)
        {

            Student[] learners = new Student[5];
            int i;
            for (i = 0; i < learners.Length; i++)
            {
                Console.WriteLine("Create student name");
                learners[i] = new Student(Console.ReadLine(), "SeDC", "G5");
                //learners[i] = new Student();
                //learners[i].Name = Console.ReadLine();
                //learners[i].Academy = "SeDC";
                //learners[i].Group = "G5";
            }
            while (true)
            {
                Console.WriteLine("Insert name of student to check if exists in the list or STOP to stop");
                string studentName = Console.ReadLine();
                if (studentName == "STOP")
                    break;
                bool checkOut = true;
                i = 0;
                while (checkOut && i < learners.Length)
                {
                    Student person = learners[i];
                    if (person.Name == studentName)
                    {
                        Console.WriteLine("Student is in the academy");
                        checkOut = false;
                    }
                    else i++;
                }
                if (checkOut)
                    Console.WriteLine("Student is not in the academy");
            }
        }
    }
}

