using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_A_Day.RandomEasy
{
    public class Valid_Anagram_LC_242_E
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            SortedDictionary<char, int> dictS =
                new SortedDictionary<char, int>();

            SortedDictionary<char, int> dictT =
                new SortedDictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dictS.ContainsKey(s[i]))
                {
                    dictS.Add(s[i], 1);
                }
                else
                {
                    dictS[s[i]]++;
                }

                if (!dictT.ContainsKey(t[i]))
                {
                    dictT.Add(t[i], 1);
                }
                else
                {
                    dictT[t[i]]++;
                }
            }

            foreach (KeyValuePair<char, int> kvp in dictS)
            {
                if (!dictT.ContainsKey(kvp.Key)) return false;
                if (dictT.ContainsKey(kvp.Key))
                {
                    if (dictT[kvp.Key] != dictS[kvp.Key]) return false;
                }

            }


            return true;
        }
        //TODO: understand
        public bool IsAnagram2(string s, string t)
        {
            int[] cntS = new int[26],
                  cntT = new int[26];

            foreach (var c in s)
                cntS[c - 'a'] += 1;

            foreach (var c in t)
                cntT[c - 'a'] += 1;

            for (int i = 0; i < 26; i++)
                if (cntS[i] != cntT[i])
                    return false;

            return true;
        }

        public bool IsAnagram3(string s, string t)
        {

            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var c in s)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map.TryAdd(c, 1);
                }
            }
            foreach (var c in t)
            {
                if (map.ContainsKey(c) && map[c] >= 1)
                {
                    map[c]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        //good one
        public bool IsAnagram4(string s, string t)
        {

            //easy case of strings not being same length
            if (s.Length != t.Length)
                return false;

            //convert strings to arrays to sort them
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            //convert arrays back to strings for comparison
            s = new string(sArray); t = new string(tArray);

            return (s == t);

        }

        /*
         func isAnagram(s string, t string) bool {
            if len(s) != len(t) {
                return false
            }
            dict := make(map[rune]int)
            for _, v := range s {
                dict[v]++
            }
            for _, v := range t {
                dict[v]--
            }
            for k, _ := range dict {
                if dict[k] != 0 {
                    return false
                }
        }
           return true
        }
         
         
         
         */
    }
}
