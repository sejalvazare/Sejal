using System;
using System.Collections.Generic;
using System.Text;

namespace day8
{
    class Sample
    {
        public Sample(int a)
        {
            Console.WriteLine("Hi i am sample" + a);
        }
    }
    class SampleB : Sample
    {
        public SampleB(int a) : base(a)
        {
            Console.WriteLine("Hi i am sample B" + a);
        }
    }
    class SampleC : SampleB
    {
        public SampleC(int a) : base(a)
        {
            Console.WriteLine("Hi i am sample C" + a);
        }
    }
    class Class2
    {
        public static void Main3()
        {
            SampleC c = new SampleC(5);
        }
    }
}
