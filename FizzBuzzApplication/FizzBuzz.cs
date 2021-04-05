//  -------------------------------------------------------------------------
//  <copyright file="FizzBuzz.cs"  author="Rajesh Thomas | iamrajthomas" >
//      Copyright (c) 2021 All Rights Reserved.
//  </copyright>
// 
//  <summary>
//       Starts FizzBuzz Application
//  </summary>
//  -------------------------------------------------------------------------

namespace FizzBuzzApplication
{
    using System;
    using System.Linq;
    public static class FizzBuzz
    {
        static int FizzBuzzRange = 30;
        public static void StartUp()
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Hello Fizz Buzz Application!");

            CreateFizzBuzz1();

            Console.WriteLine("\n\n===================================================================");
            Console.WriteLine("=================================================================== \n\n");

            Console.ForegroundColor = ConsoleColor.Green;
            CreateFizzBuzz2();

            Console.WriteLine("\n\n===================================================================");
            Console.WriteLine("=================================================================== \n\n");

            Console.ForegroundColor = ConsoleColor.Red;
            CreateFizzBuzz3();

            Console.WriteLine("\n\n===================================================================");
            Console.WriteLine("=================================================================== \n\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            CreateFizzBuzz4();

            Console.WriteLine("\n\n===================================================================");
            Console.WriteLine("=================================================================== \n\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            CreateFizzBuzz5();

            Console.WriteLine("\n\n===================================================================");
            Console.WriteLine("=================================================================== \n\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            CreateFizzBuzz6();

            Console.WriteLine("\n\n===================================================================");
            Console.WriteLine("=================================================================== \n\n");

            PrintAgain();

            Console.ReadLine();
        }

        private static void CreateFizzBuzz1()
        {

            for (int i = 1; i <= FizzBuzzRange; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }

        private static void CreateFizzBuzz2()
        {
            for (int i = 1; i <= FizzBuzzRange; i++)
            {
                var result = string.Empty;
                if (i % 3 == 0)
                    result = "Fizz";
                if (i % 5 == 0)
                    result += "Buzz";

                if (string.IsNullOrEmpty(result))
                    Console.WriteLine(i.ToString());
                else
                    Console.WriteLine(result);
            }
        }

        private static void CreateFizzBuzz3()
        {
            Enumerable.Range(1, FizzBuzzRange)
                        .Select(number => number % 3 == 0 && number % 5 == 0 ? "FizzBuzz" : number % 3 == 0 ? "Fizz" : number % 5 == 0 ? "Buzz" : number.ToString())
                        .ToList()
                        .ForEach(Console.WriteLine);
        }

        private static void CreateFizzBuzz4()
        {
            Enumerable.Range(1, FizzBuzzRange)
                .Select(number => string.Format("{0}{1}", number % 3 == 0 ? "Fizz" : String.Empty, number % 5 == 0 ? "Buzz" : string.Empty))
                .Select((result, index) => !string.IsNullOrEmpty(result) ? result : (index + 1).ToString())
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static void CreateFizzBuzz5()
        {
            var count3 = 0;
            var count5 = 0;
            for (int i = 1; i <= FizzBuzzRange; i++)
            {
                count3++;
                count5++;
                string result = string.Empty;

                if (count3 == 3)
                {
                    result += "Fizz";
                    count3 = 0;
                }
                if (count5 == 5)
                {
                    result += "Buzz";
                    count5 = 0;
                }

                if (string.IsNullOrEmpty(result))
                    Console.WriteLine(i.ToString());
                else
                    Console.WriteLine(result);
            }
        }

        private static void CreateFizzBuzz6()
        {
            for (int i = 0; i++ < FizzBuzzRange;
                Console.WriteLine("{0}{1}{2}", i % 3 == 0 ? "Fizz" : string.Empty, i % 5 == 0 ? "Buzz" : string.Empty, i % 3 != 0 && i % 5 != 0 ? i.ToString() : string.Empty)) { }
        }

        private static void PrintAgain()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Do you want to print again the FizzBuzz ? (Y/N)");
            var PrintAgain = Console.ReadLine();

            if (PrintAgain.ToUpper().Equals("Y"))
            {
                Console.Clear();
                StartUp();
            }
            else
            {
                Console.Write("Stopping FizzBuzz Application....!");
            }
        }
    }
}
