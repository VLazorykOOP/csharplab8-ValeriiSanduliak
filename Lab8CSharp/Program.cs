﻿using System;
using System.Threading.Tasks;

namespace Lab8CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 8 CSharp");

            while (true)
            {
                Console.WriteLine("=========================================================");
                Console.WriteLine("Select a task:");
                Console.WriteLine("1. Task 1");
                Console.WriteLine("2. Task 2");
                Console.WriteLine("3. Task 3");
                Console.WriteLine("4. Task 4");
                Console.WriteLine("5. Task 5");
                Console.WriteLine("6. Exit");
                Console.WriteLine("=========================================================");
                Console.Write("Enter your choice >>> ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task1.Task1_();
                        break;
                    case "2":
                        Task2.Task2_();
                        break;
                    case "3":
                        Task3.Task3_();
                        break;
                    case "4":
                        Task4.Task4_();
                        break;

                    case "5":
                        Task5.Task5_();
                        break;
                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
