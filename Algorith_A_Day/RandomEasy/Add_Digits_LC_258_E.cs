using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_A_Day.RandomEasy
{
    //https://leetcode.com/problems/add-digits/
    public class Add_Digits_LC_258_E
    {
        public int AddDigits(int num)
        {
            if (num < 10) return num;
            string tempNum = num.ToString();
            int result = 0;

            while(tempNum.Length > 1)
            {
                for (int i = 0; i < tempNum.Length; i++)
                {
                    result += int.Parse(Convert.ToString(tempNum[i]));
                }
                tempNum = result.ToString();
                if (result < 10) return result;
                result = 0;

            }
            return result;
        }

        public int AddDigits2(int num)
        {
            while (num > 9)
            {
                num = GetDigits(num);
            }
            return num;
        }
        public int GetDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        public int AddDigits3(int num)
        {

            var result = num;
            while (result >= 10)
            {
                var oneResult = 0;
                while (result > 0)
                {
                    oneResult += result % 10;
                    result /= 10;
                }
                result = oneResult;
            }

            return result;
        }

        //JS
        /*
         var addDigits = function(num) {
            let nums = num.toString().split('').map(n => Number(n));
            let added = nums.reduce((total = 0, n) => total + n);
            if (added < 10) {
                return added;
            } else {
                return addDigits(added);
            }
        };         
         */

    }
}
