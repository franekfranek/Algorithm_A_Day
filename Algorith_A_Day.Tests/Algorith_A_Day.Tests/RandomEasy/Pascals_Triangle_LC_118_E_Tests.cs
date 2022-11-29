using Algorithm_A_Day.RandomEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorith_A_Day.Tests.RandomEasy
{
    public class Pascals_Triangle_LC_118_E_Tests
    {
        private Pascals_Triangle_LC_118_E _sut;

        public Pascals_Triangle_LC_118_E_Tests()
        {
            _sut = new Pascals_Triangle_LC_118_E();
        }

        /*
        [Theory]
        [InlineData(new List<IList<int>>() { new List<int> { 1 } }, 1)]
        [InlineData(, 2)]
        [InlineData(, 2)]
        public void Interpret_ReturnsValidString_WhenValidStringPassed(IList<IList<int>> expected, int numRows)
        {
            //Arrange

            //Act
            var actual = _sut.Generate(numRows);
            //Assert
            Assert.Equal(expected, actual);
        }
        public static IList<IList<int>> Data =>
        new List<object[]>
        {
            new object[] { 1, 2, 3 },
            new object[] { -4, -6, -10 },
            new object[] { -2, 2, 0 },
            new object[] { int.MinValue, -1, int.MaxValue },
        }
        
         */

    }
}
