﻿using System;

namespace _12._Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (System.FormatException){
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
