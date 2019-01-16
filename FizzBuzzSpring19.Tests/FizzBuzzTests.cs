using System;
using Xunit;

namespace FizzBuzzSpring19.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_Returns_1_For_1()
        {
            // Arrange

            FizzBuzz underTest = new FizzBuzz();
            // int age = 17;
            //Act

            string result = underTest.Get(1);
            //Assert

            Assert.Equal("1", result);
        }
    }
}
