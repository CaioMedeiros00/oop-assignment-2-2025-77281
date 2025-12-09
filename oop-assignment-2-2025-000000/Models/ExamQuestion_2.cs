using System;
using System.Collections.Generic;
using System.Text;

namespace oop_assignment_2_2025_77281.Models
{
    // Question 2A
    public static class ExamQuestion_2A
    {
        public static void Run()
        {
            Console.WriteLine("Exam Question 2A executed.");
            int numerator = GetIntFromUser("Enter numerator: ");
            int denominator = GetIntFromUser("Enter denominator: ");
            Divide(numerator, denominator);
        }

        public static string Divide(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                var output = result.ToString();
                Console.WriteLine(output);
                return output;
            }
            catch (DivideByZeroException)
            {
                var message = "Cannot divide by zero.";
                Console.WriteLine(message);
                return message;
            }
        }

        private static int GetIntFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();
                if (int.TryParse(input, out var value))
                {
                    return value;
                }
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
    }

    // Question 2B
    public static class ExamQuestion_2B
    {
        public static void Run()
        {
            Console.WriteLine("Exam Question 2B executed.");
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            ParseNumber(input ?? string.Empty);
        }

        public static string ParseNumber(string input)
        {
            try
            {
                int value = int.Parse(input);
                var output = value.ToString();
                Console.WriteLine(output);
                return output;
            }
            catch (Exception)
            {
                var message = "Invalid number entered.";
                Console.WriteLine(message);
                return message;
            }
        }
    }

    // Question 2C
    public static class ExamQuestion_2C
    {
        public static string RegisterUser(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new ArgumentOutOfRangeException(nameof(age), "User must be at least 18 to register.");
                }

                return "Registration successful.";
            }
            catch (ArgumentOutOfRangeException)
            {
                return "User must be at least 18 to register.";
            }
        }

        public static void Run()
        {
            Console.WriteLine("Exam Question 2C executed.");
            while (true)
            {
                Console.Write("Enter age: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out var age))
                {
                    var message = RegisterUser(age);
                    Console.WriteLine(message);
                    break;
                }
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
    }
}
