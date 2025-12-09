using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_assignment_2_2025_77281.Models
{
    public static class ExamQuestion_3
    {
        public static void Run()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int> { 4, 3, 5 }),
                ("Keyboard", new List<int> { 5, 5, 5, 4 }),
                ("Mouse", new List<int> { 3, 3, 4 })
            };

            var results = ProcessProducts(products);

            foreach (var line in results.OutputLines)
            {
                Console.WriteLine(line);
            }

            if (results.TopProductName != null)
            {
                Console.WriteLine($"The top-rated product is {results.TopProductName} with an average rating of {results.TopProductAverage:F1}");
            }
        }

        public class ProcessingResult
        {
            public List<string> OutputLines { get; set; } = new List<string>();
            public string? TopProductName { get; set; }
            public double TopProductAverage { get; set; }
        }

        public static ProcessingResult ProcessProducts(List<(string Name, List<int> Ratings)> products)
        {
            var result = new ProcessingResult();

            string? topName = null;
            double topAvg = double.MinValue;

            foreach (var product in products)
            {
                if (product.Ratings == null || product.Ratings.Count == 0)
                {
                    result.OutputLines.Add($"{product.Name}: No ratings available");
                    continue;
                }

                double avg = product.Ratings.Average();
                result.OutputLines.Add($"{product.Name}: Average Rating = {avg:F1}");

                if (avg > topAvg)
                {
                    topAvg = avg;
                    topName = product.Name;
                }
            }

            if (topName != null)
            {
                result.TopProductName = topName;
                result.TopProductAverage = Math.Round(topAvg, 1);
            }

            return result;
        }
    }
}
