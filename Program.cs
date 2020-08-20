using System;

namespace math_project_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to do a math problem? Enter Y for Yes or any other key to quit.");
            var yesOrNo = Console.ReadLine();
            while (string.Equals("y", yesOrNo, StringComparison.CurrentCultureIgnoreCase)) {
                Random random = new Random();
                int a = random.Next(0,100);
                int b = random.Next(0,100);
                int answer = a + b;
                Console.WriteLine(a + " + " + b + " = ");
                
                try {
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
                } catch (Exception) {
                    Console.WriteLine("Sorry, that wasn't a number. Enter Q to Quit or any other key to continue playing.");
                    if  (string.Equals("q", Console.ReadLine(), StringComparison.CurrentCultureIgnoreCase)) {
                        Console.WriteLine("Ok, goodbye!");
                        break;
                    } 
                }                              
            }   
            Console.Write("Press any key to close the program.");
            Console.ReadKey(true);            
        }
    }
}
