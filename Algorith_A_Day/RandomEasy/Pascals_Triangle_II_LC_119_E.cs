using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_A_Day.RandomEasy
{
    //https://leetcode.com/problems/pascals-triangle-ii/
    public class Pascals_Triangle_II_LC_119_E
    {
        public static IList<int> GetRow(int rowIndex)
        {
            IList<IList<int>> result = new List<IList<int>>() { new List<int> { 1 } };
            if (rowIndex == 0) return result[0];
            IList<int> list2 = new List<int> { 1, 1 };
            result.Add(list2);
            if (rowIndex == 1) return result[1];
            

            for (int i = 1; i < rowIndex; i++)
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

            return result[rowIndex];

        }

        public IList<int> GetRow2(int rowIndex)
        {
            IList<int> prev = new List<int> { 1 };

            for (int i = 1; i <= rowIndex; i++)
            {
                IList<int> cur = new List<int> { 1 };

                for (int j = 1; j < i; j++)
                    cur.Add(prev[j - 1] + prev[j]);

                cur.Add(1);

                prev = cur;
            }

            return prev;
        }

        //recursive
        public IList<int> GetRow3(int rowIndex)
        {
            return GetRow(rowIndex, new List<int>() { 1 });
        }
        public IList<int> GetRow(int rowIndex, IList<int> prev)
        {
            if (rowIndex <= 0)
            {
                return prev;
            }
            List<int> curr = new List<int>(prev.Count + 1);
            for (int i = 0; i < prev.Count + 1; i++)
            {
                if (i == 0 || i >= prev.Count)
                {
                    curr.Insert(i, 1);
                }
                else
                {
                    curr.Insert(i, prev[i - 1] + prev[i]);
                }
            }
            return GetRow(rowIndex - 1, curr);
        }

        /*
         func getRow(rowIndex int) []int {
            if rowIndex == 0 { return []int{1} }
            res := append(getRow(rowIndex - 1),1)
            for i := rowIndex - 1; i > 0; i-- {
                res[i] = res[i-1]+res[i]
            }
            return res
         }
         
         func getRow(rowIndex int) []int {
            if rowIndex == 0 {
                return []int{1}
            }
    
            if rowIndex == 1 {
                return []int{1, 1}
            }
    
            prev := []int{1, 1}
            var now []int
            for i := 0; i < rowIndex-1; i++{
                now = []int{}
                now = append(now, 1)
                for j := 0; j < len(prev) - 1; j++ {
                    now = append(now, prev[j]+prev[j+1])
                }
                now = append(now, 1)
                prev = now
            }
    
            return now
        }
        func getRow(rowIndex int) []int {
            res := make([]int, rowIndex + 1)
            for i := range res {
                res[i] = 1
            }
            for i := 1; i < rowIndex; i++ {
                for j := i; j >= 1; j-- {
                    res[j] += res[j-1]
                }
            }
            return res
        }
         
         */
    }
}
