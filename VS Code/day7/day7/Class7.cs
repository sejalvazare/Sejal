using System;
using System.Collections;
using System.Text;

namespace day7
{
    class Class7
    {
        public static void Main7()
        {
            ArrayList al = new ArrayList();
            string str = "Sejal";
            int x = 5;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);
            al.Remove(x);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========HashTable==============");
            Hashtable ht = new Hashtable();
            ht.Add("asp", "asp.net");
            ht.Add("cs", "cs.net");
            ht.Add("vb", "vb.net");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }
            Console.WriteLine("========SortedList==============");
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("asp", "asp.net");
            sl.Add("cs", "cs.net");
            sl.Add("vb", "vb.net");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            Console.WriteLine("========Stack==============");
            Stack st = new Stack();
            st.Push("oracle");
            st.Push("asp.net");
            st.Push("cs.net");
            st.Push("vb.net");

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========Queues==============");
            Queue q = new Queue();
            q.Enqueue("oracle");
            q.Enqueue("asp.net");
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

    }
}

