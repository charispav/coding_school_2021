using Moq;
using System;
using Xunit;

namespace FibonacciClassLibrary.Tests {
    public class FibonacciCalculatorTests
        {

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(20, 6765)]
        public void FibonacciSeries_ValidInput_ReturnsExpectedOutput(long n,long expected) {

            //Arrange
             var sut = CreateDefaultSUT();

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void FibonacciSeries_NegativeInput_ThrowsArgumentException() {

            //Arrange
            var sut = CreateDefaultSUT();
            long n = -1;

            //Act + Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(n);
            });

        }

        [Fact]
        public void FibonacciSeries_BigNumberInput_ThrowsArgumentException() {

            //Arrange
            var sut = CreateDefaultSUT();
            long n = 100;

            //Act + Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(n);
            });

        }

        private static FibonacciCalculator CreateDefaultSUT() {
            //sut = system under test
            var sut = new FibonacciCalculator();
            return sut;
        }
    }
}
