using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // string [] students = new string [4];
            // students[0] = "elijah";
            // students[1] = "okechukwu";
            // students[2] = "bernice";
            // students[3] = "ekene";

            // Console.WriteLine(students[2]);

            string [] students = {"elijah","okechukwu","bernice","ekene"};
            int [] evenNumbers = {2,4,6,8};

            // foreach (var i in evenNumbers)
            // {
            //     Console.WriteLine(i+2);
            // }

            // for (int i = 0; i < 4; i+=2)
            // {
            //     Console.WriteLine(students[i]);
            // }
            // Console.WriteLine(Array.Find(students, name => name.StartsWith("ber")));
           // Console.WriteLine(Array.IndexOf(students, "bernice"));

            // int [,] a = new int [3,4] {{0,1,2,3}, {4,5,6,7}, {8,9,10,11}};
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 4; j++)
            //     {
            //         Console.WriteLine(a[i,j]);
            //     }
            // }



           int [,] a =  new int [4,4]
           {
               {1,2,3,4},
               {1,2,6,4},
               {1,2,3,4},
               {1,2,3,4}
           };
           
           for (int row = 0; row < 4; row++)
          {
            Console.WriteLine("this is row " + row);

            for (int col = 0; col < 4; col++) 

            {
               Console.WriteLine(a[row,col]);
            }    
          }
           
           
        }
    }
}
