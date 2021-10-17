using System;
using System.Threading;

namespace age_calculator
{
    class Program
    {
        static string PromptUser(string question)
        {
            Console.Write($"{question} ");
            var answer = Console.ReadLine();
            return answer;
        }

        static void CalculateTime(int age)
        {
            Console.WriteLine($"You are {age} years, {age * 12} months, {age * 365} days, {age * 365 * 60} minutes, and {age * 365 * 60 * 60} seconds old.");
        }

        static void Main(string[] args)
        {
            // 1. Greet user
            Console.WriteLine("Welcome to the Age Calculator app!");
            Thread.Sleep(1000);

            // 2. Ask user for name
            var name = PromptUser("What is your name?");
            Thread.Sleep(1000);
            Console.WriteLine($"Let's calculate your age in months, days, minutes, and seconds, {name}.");
            Thread.Sleep(1000);

            // 3. Ask user for age
            int age = int.Parse(PromptUser("Hold old are you (in years)?"));
            Thread.Sleep(1000);
            Console.WriteLine($"You entered {age} years.");

            // 4. Calculate age in months, days, minutes, and seconds
            Thread.Sleep(1000);
            CalculateTime(age);
        }
    }
}
