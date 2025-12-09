using System.Collections.Generic;
using oop_assignment_2_2025_77281.Models;
using Xunit;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_3
    {
        [Fact]
        public void ProcessProducts_ProducesCorrectAveragesAndTopProduct()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int> { 4, 3, 5 }),
                ("Keyboard", new List<int> { 5, 5, 5, 4 }),
                ("Mouse", new List<int> { 3, 3, 4 })
            };

            var result = ExamQuestion_3.ProcessProducts(products);

            Assert.Contains("Laptop: Average Rating = 4.2", result.OutputLines);
            Assert.Contains("Headphones: Average Rating = 4.0", result.OutputLines);
            Assert.Contains("Keyboard: Average Rating = 4.8", result.OutputLines);
            Assert.Contains("Mouse: Average Rating = 3.3", result.OutputLines);

            Assert.Equal("Keyboard", result.TopProductName);
            Assert.Equal(4.8, result.TopProductAverage);
        }

        [Fact]
        public void ProcessProducts_HandlesEmptyRatings()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Gadget", new List<int>())
            };

            var result = ExamQuestion_3.ProcessProducts(products);

            Assert.Contains("Gadget: No ratings available", result.OutputLines);
            Assert.Null(result.TopProductName);
        }
    }
}
