using Xunit;
using oop_assignment_2_2025_77281.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_2

        //QUESTION 2A
    {
        [Fact]
        public void Divide_ReturnsQuotient_WhenDenominatorNonZero()
        {
            
            int a = 10;
            int b = 2;
            var result = ExamQuestion_2A.Divide(a, b);
            Assert.Equal("5", result);
        }

        [Fact]
        public void Divide_ReturnsErrorMessage_WhenDivideByZero()
        {

            int a = 10;
            int b = 0;
            var result = ExamQuestion_2A.Divide(a, b);
            Assert.Equal("Cannot divide by zero.", result);
        }

        [Fact]
        public void ParseNumber_ReturnsNumber_WhenValid()
        {

            var input = "123";
            var result = ExamQuestion_2B.ParseNumber(input);
            Assert.Equal("123", result);
        }

        //QUESTION 2B
        [Fact]
        public void ParseNumber_ReturnsErrorMessage_WhenInvalid()
        {

            var input = "abc";
            var result = ExamQuestion_2B.ParseNumber(input);
            Assert.Equal("Invalid number entered.", result);
        }

        //QUESTION 2C
        [Fact]
        public void RegisterUser_ReturnsSuccess_WhenAgeIsAtLeast18()
        {

            int age = 25;
            var result = ExamQuestion_2C.RegisterUser(age);
            Assert.Equal("Registration successful.", result);
        }

        [Fact]
        public void RegisterUser_ReturnsErrorMessage_WhenUnder18()
        {
            int age = 15;
            var result = ExamQuestion_2C.RegisterUser(age);
            Assert.Equal("User must be at least 18 to register.", result);
        }
    }
}
