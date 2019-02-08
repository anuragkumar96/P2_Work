using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Cube_WorksWithOneInteger()
        {
            var expected = 8;
            var a = 2;
            
            var actual = Cube(a);
            Assert.Equal(expected,actual);
        }

        

    

        [Theory]
        [InlineData(10)]
        [InlineData(-10)]
        [InlineData(0)]
        public void Divisibleby10_WorksWithOneInput(int n1)
        {
            Assert.True(Divisibleby10(n1));
        }
         

        int Cube(int x)
        {
            return x * x * x;
        }

        bool Divisibleby10(int value)
        {
            return value % 10 == 0;
        }
    }
}
