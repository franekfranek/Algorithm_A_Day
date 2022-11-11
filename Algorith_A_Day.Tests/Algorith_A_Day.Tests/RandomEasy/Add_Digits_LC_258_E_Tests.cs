using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algorithm_A_Day.RandomEasy;

namespace Algorith_A_Day.Tests.RandomEasy
{
    public class Add_Digits_LC_258_E_Tests
    {
        private readonly Add_Digits_LC_258_E _sut;
       
        public Add_Digits_LC_258_E_Tests()
        {
            _sut = new Add_Digits_LC_258_E();
        }


        [Theory]
        [InlineData(38, 2)]
        [InlineData(33, 6)]
        [InlineData(127, 1)]
        [InlineData(99, 9)]
        [InlineData(0, 0)]
        public void AddDigits_ReturnsInt_WhenAProperIntPassed(int a, int expected)
        {
            //Arrange

            //Act
            var actual = _sut.AddDigits(a);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
