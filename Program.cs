﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conarray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[4, 3];
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter Student {i + 1}\'s Roll Number");
                marks[i, 0] = int.Parse(Console.ReadLine());
                for(int j = 1; j < 3; j++)
                {
                    Console.WriteLine($"Enter marks of student\'s{i + 1} in sem {j}");
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Marks List as Follows");
            Console.WriteLine("RollNo\tSemone\tSemTwo");
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(marks[i, j] + " \t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }
        
    }
}
