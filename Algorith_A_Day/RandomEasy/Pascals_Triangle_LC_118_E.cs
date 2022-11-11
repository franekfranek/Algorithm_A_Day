using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_A_Day.RandomEasy
{

    //https://leetcode.com/problems/pascals-triangle/description/
    public class Pascals_Triangle_LC_118_E
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> list1 = new List<int> { 1 };
            result.Add(list1);
            if (numRows == 1) return result;
            IList<int> list2 = new List<int> { 1, 1 };    
            result.Add(list2);

            for (int i = 1; i < numRows - 1; i++)
            {
                IList<int> tempListToAdd = new List<int>();
                IList<int> tempList = result[i];
                tempListToAdd.Add(1);
                for (int j = 0; j < tempList.Count; j++)
                {
                    if (j < (tempList.Count - 1))
                    {
                        int middleItem = tempList[j] + tempList[j + 1];
                        tempListToAdd.Add(middleItem);
                    }                 
                }
                tempListToAdd.Add(1);
                result.Add(tempListToAdd);
            }

            return result;
        }
        public IList<IList<int>> Generate2(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>() { new List<int>() { 1 } };

            for (int i = 2; i <= numRows; i++)
            {
                List<int> cur = new List<int>() { 1 };

                for (int j = 1; j < i - 1; j++)
                    cur.Add(res[i - 2][j - 1] + res[i - 2][j]);

                cur.Add(1);

                res.Add(cur);
            }

            return res;
        }

        //recursion :O
        public IList<IList<int>> Generate3(int numRows)
        {
            IList<IList<int>> returnList = new List<IList<int>>();
            if (numRows < 1)
                return returnList;
            List<int> rowList = new List<int>() { 1 };
            returnList.Add(rowList);

            Generate(numRows, returnList);
            return returnList;
        }

        private void Generate(int i, IList<IList<int>> myList)
        {
            if (i == 1)
            {
                return;
            }
            else
            {
                Generate(i - 1, myList);
                List<int> rowList = new List<int>();
                List<int> prevRow = new List<int>();
                prevRow = myList[i - 2].ToList<int>(); // i is length not index, so need to subtract 2
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i)
                    {
                        rowList.Add(1);
                    }
                    else
                        rowList.Add(prevRow[j - 2] + prevRow[j - 1]);
                }
                myList.Add(rowList);
            }
        }
        //JS
        /*
            var generate = function(numRows) {

           let result = [];

           if (numRows < 1) {
               return result;
           }

           result.push([1])

           if (numRows === 1) {
               return result;
           }

           result.push([1, 1])

           for (let i=3; i <= numRows; ++i) {
               let last = result[i - 2];
               let newArr = [];

               newArr.push(1);

               for (let j=0, k=1; k < i-1; j++) {
                   newArr.push(last[j] + last[k]);
                   k++;
               }

               newArr.push(1);

               result.push(newArr);
               }

               return result;

           };


            */

        //go
        /*
         func generate(numRows int) [][]int {
            res := [][]int{}
            prev := []int{1}
            res = append(res,prev)
            for i:=2;i<=numRows;i++{
                prev = append(prev,0)
                newRow := []int{1}
                for j:=0;j<len(prev)-1;j++{
                    newRow = append(newRow,prev[j]+prev[j+1])
                }
                res = append(res,newRow)
                prev = newRow
            }
            return res
         }
        */
    }
}
