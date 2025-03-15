using System;
using System.IO;
namespace HW;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("please enter name");
            string Studentname = Console.ReadLine();
            Console.WriteLine("please enter stdid");
            int studentid = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter natid");
            int nationalid = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the Credites");
            int studentcredites = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the activity");
            bool activity = bool.Parse(Console.ReadLine());


            Student s = new Student(Studentname, studentid, nationalid, studentcredites, activity);
            File.AppendAllText("student.csv", s.ToString() + Environment.NewLine);
            Console.WriteLine("Student added successfully!");

            

        }   
    }
}
