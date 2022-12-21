using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_A_Day.RandomEasy
{
	//https://leetcode.com/problems/di-string-match/
	//2 pointer pattern can be applied
	public class DI_String_Match_LC_942_E
	{
		public int[] DiStringMatch(string s)
		{
			if (s == "" || s.Length == 0) return Array.Empty<int>();

			int n = s.Length;
			List<int> availableNumbers = Enumerable.Range(0, n + 1).ToList();
			int[] result = new int[n + 1];

			for (int i = 0; i <= s.Length; i++)
			{
				if (i == s.Length)
				{
					result[i] = availableNumbers[0];
				}
				else
				{
					if (s[i] == 'I')
					{
						result[i] = availableNumbers.Min();
						availableNumbers.RemoveAt(0);
					}

					if (s[i] == 'D')
					{
						result[i] = availableNumbers.Max();
						availableNumbers.RemoveAt(availableNumbers.Count - 1);
					}
				}
			}

			return result;
		}
		//"IDID"
		//[0, 1, 2, 3, 4];
		//[0, 3, 1, 4, 2];
		//DDI
		//[0, 1, 2, 3]
		//[3,2,0,1]
		//[,]
		//if s[0] == D take biggest number from list of available ones
		//if s[1] == I take smaller number
		//

		public int[] DiStringMatch2(string s)
		{
			int low = 0, high = s.Length;
			int[] result = new int[s.Length + 1];

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == 'I')
				{
					result[i] = low++;
				}
				else
				{
					result[i] = high--;
				}
			}

			result[s.Length] = low < high ? low : high;
			return result;
		}

		public int[] DiStringMatch3(string S)
		{
			int[] result = new int[S.Length + 1];
			int d = 0;
			int i = S.Length;
			int index = 0;
			foreach (char c in S)
			{
				if (c == 'D') result[index++] = i--;
				if (c == 'I') result[index++] = d++;
			}
			result[index] = i;
			return result;
		}
		//go
		/*
		 func diStringMatch(s string) []int {
			var n []int
			i := 0
			d := len(s)
			for j := 0; j < len(s); j++ {
				if string(s[j]) == "I" {
					n = append(n, i)
					i++
				} else if string(s[j]) == "D" {
					n = append(n, d)
					d--
				}
				if j == len(s)-1 {
					if string(s[j]) == "I" {
						n = append(n, i)
						i++
					} else if string(s[j]) == "D" {
						n = append(n, d)
						d--
					}
				}
			}
		  return n
		 }
		Start with a sorted array. 
		Loop through the array, for each index if it should be decreasing/increasing and it's not, then swap the elements. 
		Keep doing this until you can go through the array without swapping anything.
		 func diStringMatch(S string) []int {
			arr := make([]int, len(S) + 1)
			for i := 0; i <= len(S); i++ {
				arr[i] = i
			}
			done := false
			for !done {
				done = true
				for i := 0; i < len(S); i++ {
					if S[i] == 'D' && arr[i] < arr[i+1] {
						arr[i], arr[i+1] = arr[i+1], arr[i]
						done = false
					} else if S[i] == 'I' && arr[i] > arr[i+1] {
						arr[i], arr[i+1] = arr[i+1], arr[i]
						done = false
					}
				}
			}
			return arr
			}
			func diStringMatch(S string) []int {
				i,j := 0,len(S)
				ret := make([]int,len(S)+1)
				for k:=0;k<len(S);k++{
					if S[k] == 'I'{
						ret[k] = i
						i++
					}else{
						ret[k] = j
						j--
					}
				}
				ret[len(S)] = i
				return ret
	
}
		 
		 */
	}
}
