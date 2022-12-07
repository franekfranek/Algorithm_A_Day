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
            IList<IList<int>> result = new List<IList<int>>() { new List<int> { 1 } };
        }


        [Theory]
        [MemberData(nameof(Data))]
        public void ReturnListOfListsWhenIntPassed(IList<IList<int>> expected, int numRows)
        {
            //Arrange

            //Act
            var actual = _sut.Generate(numRows);
            //Assert
            Assert.Equal(expected, actual);
        }
        public static TheoryData<IList<IList<int>>, int> Data
        {
            get
            {
                var data = new TheoryData<IList<IList<int>>, int>();
                IList<IList<int>> list1 = new List<IList<int>>() { new List<int> { 1 } };
                IList<IList<int>> list2 = new List<IList<int>>()
                { new List<int> { 1 },
                  new List<int> { 1, 1 }
                };
                IList<IList<int>> list3 = new List<IList<int>>()
                { new List<int> { 1 },
                  new List<int> { 1, 1 },
                  new List<int> { 1, 2, 1 }
                };
                IList<IList<int>> list4 = new List<IList<int>>()
                { new List<int> { 1 },
                  new List<int> { 1, 1 },
                  new List<int> { 1, 2, 1 },
                  new List<int> { 1, 3, 3, 1 }
                };
                IList<IList<int>> list5 = new List<IList<int>>()
                { new List<int> { 1 },
                  new List<int> { 1, 1 },
                  new List<int> { 1, 2, 1 },
                  new List<int> { 1, 3, 3, 1 },
                  new List<int> { 1, 4, 6, 4, 1 }
                };

                data.Add(list1, 1);
                data.Add(list2, 2);
                data.Add(list3, 3);
                data.Add(list4, 4);
                data.Add(list5, 5);

                return data;
            }
        }
    }
}
        /*   
           public static IList<IList<int>> Data =>
           new List<object[]>
           {
               new object[] { ,2 },
               new object[] { -4, -6, -10 },
               new object[] { -2, 2, 0 },
               new object[] { int.MinValue, -1, int.MaxValue },
           }

           public class CalculatorTestData : IEnumerable<object[]>
   {
       public IEnumerator<object[]> GetEnumerator()
       {
           yield return new object[] { 1, 2, 3 };
           yield return new object[] { -4, -6, -10 };
           yield return new object[] { -2, 2, 0 };
           yield return new object[] { int.MinValue, -1, int.MaxValue };
       }

       IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
   }


       }*/
    
