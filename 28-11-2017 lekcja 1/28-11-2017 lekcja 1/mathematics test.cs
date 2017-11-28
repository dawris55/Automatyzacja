using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using System.Text;
using System.Threading.Tasks;


namespace _28_11_2017_lekcja_1
{
    public class mathematics_test
    {
        [Theory]
        [InlineData(10, 20, 30)]
        public void theoryexample(double x, double y, double expected)
        {
            // arrange
            var math = new Mathematics();
            // act
            double result = math.Add(x, y);
            // assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Add_returns_sum_of_given_values()
        {
            // arrange
            var math = new Mathematics();
            // act
            double result = math.Add(10, 57);
            // assert
            Assert.Equal(67, result);
        }
        [Fact]
        public void Add_returns_sum_of_given_valuesv2()
        {
            // arrange
            var math = new Mathematics();
            // act
            double result = math.Add(-10, 57);
            // assert
            Assert.Equal(47, result);
        }
        [Fact]
        public void Substract_returns_diverence_of_given_values()
        {
            // arrange
            var math = new Mathematics();
            // act
            double result = math.substract(10, 57);
            // assert
            Assert.Equal(-47, result);
        }
        [Fact]
        public void Substract_returns_diverence_of_given_valuesv2()
        {
            // arrange
            var math = new Mathematics();
            // act
            double result = math.substract(10, 3);
            // assert
            Assert.Equal(7, result);
        }
        [Fact]
        public void Multiply_returns_multiplication_of_given_values()
        {
            // arrange
            var math = new Mathematics();
            // act
            double result = math.multiply(10, 3);
            // assert
            Assert.Equal(30, result);
        }
        [Fact]
        public void Multiply_returns_multiplication_of_given_valuesv2()
        {
            // arrange
            var math = new Mathematics();
            // act
            double result = math.multiply(10, 30);
            // assert
            Assert.Equal(300, result);
        }
        [Fact]
        public void Divide_returns_who_knows_what_of_given_values()
        {
            // arrange
            var math = new Mathematics();
            // act
            double result = math.divide(10, 5);
            // assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void Divide_returns_who_knows_what_of_given_valuesv2()
        {
            // arrange
            var math = new Mathematics();
            // act
            double result = math.divide(99, 3);
            // assert
            Assert.Equal(33, result);
        }
    }
}
