using Algorithm_A_Day.RandomEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorith_A_Day.Tests.RandomEasy
{
    public class Pascals_Triangle_II_LC_119_E_Tests
    {
        private Pascals_Triangle_II_LC_119_E _sut;

        public Pascals_Triangle_II_LC_119_E_Tests()
        {
            _sut = new Pascals_Triangle_II_LC_119_E();
        }


        [Theory]
        [MemberData(nameof(Data))]
        public void ReturnListOfListsWhenIntPassed(IList<int> expected, int numRows)
        {
            //Arrange

            //Act
            var actual = _sut.GetRow(numRows);
            //Assert
            Assert.Equal(expected, actual);
        }
        public static TheoryData<IList<int>, int> Data
        {
            get
            {
                var data = new TheoryData<IList<int>, int>();
                IList<int> list1 = new List<int>() { 1 };
                IList<int> list2 = new List<int>() { 1, 1 };
                IList<int> list3 = new List<int>() { 1, 2, 1 };
                IList<int> list4 = new List<int>() { 1, 3, 3, 1 };
                IList<int> list5 = new List<int>() { 1, 4, 6, 4, 1 };
               

                data.Add(list1, 0);
                data.Add(list2, 1);
                data.Add(list3, 2);
                data.Add(list4, 3);
                data.Add(list5, 4);

                return data;
            }
        }
    }
}
