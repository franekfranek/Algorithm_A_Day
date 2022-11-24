using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_A_Day.RandomEasy
{
    public class Student_Attendance_Record_I_LC_551_E
    {
        public static bool CheckRecord(string s)
        {
            int absencesNumber = 0;
            int consecutiveDays = 0;
            bool eligble = true;
            bool wasPreviousL = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    absencesNumber++;
                    wasPreviousL = false;
                    consecutiveDays = 0;
                }
                else if (s[i] == 'P')
                {
                    wasPreviousL = false;
                    consecutiveDays = 0;
                }
                if (s[i] == 'L')
                {
                    wasPreviousL = true;
                    if (wasPreviousL) consecutiveDays++;
                    if (consecutiveDays > 2) eligble = false;
                }
            }
            if (absencesNumber > 1) eligble = false;

            return eligble;
        }

        public bool CheckRecord2(string s)
        {
            if (s == null || s == string.Empty)
                return false;

            int count = 0, longestCount = 0;
            Hashtable record = new Hashtable();
            char[] temp = s.ToUpper().ToCharArray();

            record.Add('A', 0);

            if (temp[0] == 'A')
                record['A'] = (int)record['A'] + 1;

            for (int i = 1; i <= temp.Length - 1; i++)
            {
                if (temp[i] == 'A')
                    record['A'] = (int)record['A'] + 1;

                if (temp[i] == 'L' && temp[i - 1] == 'L')
                {
                    count++;
                    if (count > longestCount)
                        longestCount = count;
                }
                else
                    count = 0;
            }

            if ((int)record['A'] > 1 || longestCount >= 2)
                return false;

            return true;
        }
        public bool CheckRecord3(string s)
        {
            int count = 0;
            bool isA = false;
            foreach (char c in s)
            {
                switch (c)
                {
                    case 'A':
                        if (isA)
                            return false;
                        isA = true;
                        count = 0;
                        break;
                    case 'L':
                        count++;
                        break;
                    case 'P':
                        count = 0;
                        break;
                    default:
                        return false;
                        break;
                }

                if (count > 2)
                    return false;
            }

            return true;
        }
        //LOL
        public bool CheckRecord4(string s)
        {
            int firstA = s.IndexOf("A");
            int lastA = s.LastIndexOf("A");

            if (firstA != lastA)
            {
                return false;
            }

            if (s.IndexOf("LLL") >= 0)
            {
                return false;
            }

            return true;
        }

        //go
        /*
         func checkRecord(s string) bool {
    return !(strings.Count(s, `A`) > 1) && !strings.Contains(s, `LLL`)


        func checkRecord(s string) bool {
    awd := true
    absents, late := 0, 0
    var p rune
    for _, c := range(s) {
        switch(c){
            case 'P' : ;
            case 'A' : absents++; if absents == 2 { awd = false; break }
            case 'L' : 
                // if prev was 'L' then we bump count else reset it to 1
                if p == c {late++} else {late=1} 
                // if more than 2 lates, no award
                if late == 3 {awd = false; break}
        }
        // update previous to current
        p = c
    }
    return awd
}
}
         */
    }
}
