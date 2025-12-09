using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;

namespace oop_assignment_2_2025_77281.Models
{
    public static class ExamQuestion_1
    {
        private static readonly Regex IrishMobileRegex = new Regex(@"^(?:083|085|089)\d{7}$", RegexOptions.Compiled);

        public static bool IsValidIrishMobile(string? input)
            
        {
                if (string.IsNullOrEmpty(input)) return false;
                return IrishMobileRegex.IsMatch(input);

        }
        


        public static void Run()
        {
            Console.WriteLine("Exam Question 1 executed.");
            SampleQuestionAMethod();
            SampleQuestionBMethod();
            Console.WriteLine(GetDiscountPercentage("Bronze"));
        }
        public static void SampleQuestionAMethod()
        {
            // Sample method implementation
            Console.WriteLine("VIP");
        }

        public static void SampleQuestionBMethod()
        {
            // Sample method implementation
            Console.WriteLine("Gold");
        }
        public static int GetDiscountPercentage(string level)
        {
            if (string.IsNullOrWhiteSpace(level))
            {
                return 0;
            }

            return level.Trim().ToLowerInvariant() switch
            {
                "Bronze" => 1,
                "Silver" => 5,
                "Gold" => 10,
                "Platinum" => 15,
                "Diamond" => 20,
                "Elite" => 25,
                "VIP" => 30,
                _ => 0,
            };
        }

    }
}
