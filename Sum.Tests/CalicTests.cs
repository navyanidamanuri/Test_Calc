using sum;
using System;
using Xunit;

namespace Sum.Tests
{
    public class CalicTests
    {
        [Fact]
        public void addingtwodoublenumbers()
        {
            //    //Arrange
            
            double expected = 5;

            //Act
            double result = Calic.addition(2,3);

            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void addingtwodoublenumbersnegetive()
        {
            //    //Arrange

            double expected = 6;

            //Act
            double result = Calic.addition(2, 3);

            //Assert
            Assert.NotEqual(expected, result);
        }
        [Fact]
        public void substractingtwodoublenumbers()
        {
            //    //Arrange

            double expected = -1;

            //Act
            double result = Calic.substraction(2, 3);

            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void addingarrynumbers()
        {
              //Arrange
           double expected = 14;
            //Act
            Double[] arr = new Double[5] { 1, 2, 2, 4, 5 };
            
             double result = Calic.addition(arr);

            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void substractingarrynumbers()
        {
            //Arrange
            double expected = -60.6;
            //Act
            Double[] arr = new Double[4] { -2.2,5.5,-8.2,61.1 };
            double result = Calic.substraction(arr);

            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void multiplicationdoublenumbers()
        {
            //Arrange
            double expected = 45;
            //Act
            
             double result = Calic.multiplication(5,9);

            //Assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Divisionoftwonumbers()
        {
            //Arrange

            //Act
            var Exception = Record.Exception(() => Calic.division(10, 0));
            
            //Assert
            Assert.IsType<DivideByZeroException>(Exception);
        }

    }
}
