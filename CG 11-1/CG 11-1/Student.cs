using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace CG_11_1
{

    //create a student class

    class Student

    {
        //create an array to store the text file and return it

        public string[] StudentData { get; set; }
        public string Name { get; set; }

        //create a method to list out student names if they have more than 6 scores
        public string StudentNames()

        {
            //specify which text file you would like the program to read
            StudentData = File.ReadAllLines(@"C:\Users\hogan\Source\Repos\CG-11-1\CG 11-1\CG 11-1\student names.txt");

            //use a loop to go through each line of data and only store and return the names of those that have more than 6 quiz scores
            foreach (string s in StudentData)

            {
                string[] score = s.Split(' ');
                int l = score.Length;
                if (l > 7)
                {
                    Name = score[0];
                }
            }

            return Name;





        }

    }
}