﻿using System;

namespace math_project_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWould you like to do a math problem? ");
            var yesOrNo = Console.ReadLine();
            while (string.Equals("y", yesOrNo, StringComparison.CurrentCultureIgnoreCase)) {
                Random random = new Random();
                int a = random.Next(0,100);
                int b = random.Next(0,100);
                int answer = a + b;
                Console.WriteLine(a + " + " + b + " = ");
                
                int userAnswer = int.Parse(Console.ReadLine());                

                if (answer == userAnswer) {
                    Console.WriteLine("That's correct! Here's another:");
                } else {
                    while (answer != userAnswer) {
                        Console.WriteLine("That is incorrect. Guess again:");
                        int tryAgain = int.Parse(Console.ReadLine());     
                        if (tryAgain == answer) {
                            Console.WriteLine("That's correct! Here's another:");
                            break;
                        }
                    }
                }
            }   
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);            
        }
    }
}