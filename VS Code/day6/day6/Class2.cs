using System;
using System.Collections.Generic;
using System.Text;

namespace  day6

    class number
{
    static internal maxCHARS=256;
        static void calculate(String s,int[] cal)
    {
        for (int i = 0; i < s.Length; i++)
            cal[s[i]]++;
    }
    class Class2

        public static void Main()
    {
        String s = "aabbab";

        int[] cal = new int[maxCHARS];
        calculate(s, cal);

        for(int i=0;i<maxCHARS;i++)
            if(cal[i]>1)
            {
                Console.WriteLine("Character" + (char)i);
                Console.WriteLine("Occurances" + cal[i]+"times");
            }
    }
}
