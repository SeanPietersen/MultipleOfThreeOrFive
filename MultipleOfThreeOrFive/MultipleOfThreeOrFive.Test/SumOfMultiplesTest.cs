using MultipleOfThreeOrFive.App;
using Xunit;

namespace MultipleOfThreeOrFive.Test
{
    public class SumOfMultiplesTest
    {
        [Fact]
        public void CalculateSumOfMultiplesOfThreeOrFiveTest1_Successful()
        {
            //Arrange
            ISumOfMultiples sumOfMultiples = new SumOfMultiples();
            int expected = 23;
            int value = 10;

            //Act
            var actual = sumOfMultiples.CalculateSumOfMultiplesOfThreeOrFive(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateSumOfMultiplesOfThreeOrFiveTest2_ShouldReturnNull_WhenValueIsLessThanZero()
        {
            //Arrange
            ISumOfMultiples sumOfMultiples = new SumOfMultiples();
            int expected = 0;
            int value = -1;

            //Act
            var actual = sumOfMultiples.CalculateSumOfMultiplesOfThreeOrFive(value);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
