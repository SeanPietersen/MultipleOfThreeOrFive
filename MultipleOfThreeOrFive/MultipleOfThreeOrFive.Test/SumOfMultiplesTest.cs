using MultipleOfThreeOrFive.App;
using Xunit;

namespace MultipleOfThreeOrFive.Test
{
    public class SumOfMultiplesTest
    {
        [Fact]
        public void SolutionTest1()
        {
            //Arrange
            ISumOfMultiples sumOfMultiples = new SumOfMultiples();
            int expected = 23;
            int value = 10;

            //Act
            var actual = sumOfMultiples.Solution(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolutionTest2()
        {
            //Arrange
            ISumOfMultiples sumOfMultiples = new SumOfMultiples();
            int expected = 0;
            int value = -1;

            //Act
            var actual = sumOfMultiples.Solution(value);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
