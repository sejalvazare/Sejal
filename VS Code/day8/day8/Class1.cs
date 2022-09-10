using System;
using System.Collections.Generic;
using System.Text;

namespace day8
{
    class Myexception : Exception
    {
        public Myexception(String Message) : base(Message)
        {

        }
    }
    class Class1

    {
        static void Validate(int age)
        {
            if (age < 18)
            {
                //when we want we can raise exception by using throw
                throw new Myexception("Please enter age greater than 18");
            }
        }
        public static void Main2()
        {
            try
            {
                Validate(15);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
    

