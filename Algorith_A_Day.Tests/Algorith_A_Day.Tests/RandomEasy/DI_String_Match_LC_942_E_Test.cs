using Algorithm_A_Day.RandomEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorith_A_Day.Tests.RandomEasy
{
    public class DI_String_Match_LC_942_E_Test
    {
        private readonly DI_String_Match_LC_942_E _sut;

        public DI_String_Match_LC_942_E_Test()
        {
            _sut = new DI_String_Match_LC_942_E();
        }

        [Theory]
        [InlineData("IDID", new int[] { 0, 4, 1, 3, 2 })]
        [InlineData("III", new int[] { 0, 1, 2, 3 })]
        [InlineData("DDI", new int[] { 3, 2, 0, 1 })]
        [InlineData("", new int[] { })]
        public void DiStringMatch_ReturnsIntArray_WhenValidStringPassed(string s, int[] expected)
        {
            //Arrange

            //Act
            var actual = _sut.DiStringMatch(s);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
