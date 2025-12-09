using oop_assignment_2_2025_77281.Models;
using Xunit;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_1
    {
        [Theory]
        [InlineData("0831234567", true)]
        [InlineData("0899988776", true)]
        [InlineData("0812345678", false)]
        [InlineData("083 1234567", false)]
        [InlineData("08312345678", false)]
        public void IsValidIrishMobile_Test(string phoneNumber, bool expected)
        {
            bool actual = ExamQuestion_1.IsValidIrishMobile(phoneNumber);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Bronze", 1)]
        [InlineData("Silver", 5)]
        [InlineData("Gold", 10)]
        [InlineData("Platinum", 15)]
        [InlineData("Diamond", 20)]
        [InlineData("Elite", 25)]
        [InlineData("VIP", 30)]
        [InlineData("Unknown", 0)]
        [InlineData("", 0)]
        [InlineData("  gold  ", 10)]
        public void GetDiscountPercentage_ReturnsExpected(string level, int expected)
        {
            int actual = ExamQuestion_1.GetDiscountPercentage(level);
            Assert.Equal(expected, actual);
        }
    }
}
