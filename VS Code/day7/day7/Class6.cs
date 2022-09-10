using System;
using System.Collections.Generic;
using System.Text;

namespace day7
{
    class IndexerClass
    {
        private string[] name = new string[3];
        public string this[int i]
        {
            get
            {
                return name[i];
            }
            set
            {
                name[i] = value;
            }
        }
    }
    class Class6
    {
        public static void Main6()
        {
            IndexerClass c = new IndexerClass();
            c[0] = "Sejal";
            c[1] = "rose";
            c[2] = "goldy";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(c[i]);
            }

        }
    }
}
