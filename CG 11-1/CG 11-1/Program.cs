using System;

namespace CG_11_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //create student and use this to call your student class 
            Student student = new Student();
            Console.WriteLine("Please press enter to find out the names of students that have more than 6 quiz scores.");
            Console.ReadLine();

            //write the student names to the console and add that this student or students has more than 6 quiz scores. 
            Console.WriteLine(student.StudentNames() + " " + "has more than 6 quiz scores.");
        
            Console.ReadLine();
        }
    }
}
