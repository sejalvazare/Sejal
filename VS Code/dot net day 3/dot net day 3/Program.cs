using System;

namespace dot_net_day_3
{
    class class8
    {
        public static void Main(string[] args)
        {
            SumIN(1, 2);
            int result;
            SumOut(1, 2, out result);
            Console.WriteLine("output from output parameter" + result);

            SumNamed(b = 1, char = 2, args = 3);
            SumOptional(10, 10);
        }
        public static void SumIN(in int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static void SumOut(in int a, int b,int c)
        {
            Console.WriteLine("sum from named parameters" + (a+b+c);
            Console.WriteLine("b="+b);
            Console.WriteLine("c=" + c);

        }
        public static void SumOptional(in int a, int b=10, int c=20)
        {

            Console.WriteLine("the optional output is" + (a + b + c);
        }
           
    }
}
