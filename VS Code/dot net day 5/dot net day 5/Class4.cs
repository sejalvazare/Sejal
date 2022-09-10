using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_day_5
{
        class MethodOverloading
        {
            public void Mul(int a, int b)
            {
                Console.WriteLine(a * b);
            }
            public void Mul(int a, int b, int c)
            {
                Console.WriteLine(a * b * c);
            }
            public void Mul(double a, double b)
            {
                Console.WriteLine(a * b);
            }
        }
        class Class5
        {
            public static void Main()
            {
                MethodOverloading obj = new MethodOverloading();
                obj.Mul(1, 2);
                obj.Mul(1, 2, 3);
                obj.Mul(23,45);
            }
        }
    }
}
}
