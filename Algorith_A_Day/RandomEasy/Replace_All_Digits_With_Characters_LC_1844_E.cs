using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_A_Day.RandomEasy
{
    public class Replace_All_Digits_With_Characters_LC_1844_E
    {
        public string ReplaceDigits(string s)
        {
            string alphabet = string.Empty;
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet += i;
            }

            StringBuilder sb = new StringBuilder(s);

            for (int i = 1; i < s.Length; i+=2)
             {
                sb[i] = Shift(s[i - 1], (int)Char.GetNumericValue(s[i]), alphabet);
            }
            
            return sb.ToString();
        }

        private char Shift(char c, int x, string al)
        {
            int targetIndex = x;

            for (int i = 0; i <= al.Length; i++)
            {
                if (al[i] == c)
                {
                    targetIndex = i;
                    break;
                }
            }
    
        return al[targetIndex + x];
        }

        public string ReplaceDigits2(string s)
        {
            var carr = s.ToCharArray();
            for (var i = 1; i < carr.Length; i += 2)
            {
                carr[i] = shift(carr[i - 1], carr[i] - '0');
            }
            return new string(carr);
        }

        char shift(char c, int x)
        {
            return (char)(c + x);
        }
        //ehhhh XD
        public string ReplaceDigits3(string s)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                    sb.Append(s[i]);
                else
                    sb.Append(Convert.ToChar(s[i - 1] - '0' + Convert.ToInt32(s[i])));
            }
            return sb.ToString();
        }

        /*
         func replaceDigits(s string) string {
            var result strings.Builder
    
            for i := 0; i < len(s); i++ {
                if i%2 == 1 {
                    result.WriteByte(s[i-1] + toInt(s[i]))
                } else {
                    result.WriteByte(s[i])
                }
            }
    
            return result.String()
        }

        func toInt(char byte) byte {
            return char - '0'
        }
         
         
         
         */

    }
}
//"a1b2c3d4e"
//012345678
//"abbdcfdhe"