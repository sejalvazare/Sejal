using System;

namespace dot_net_day_5
{
    abstract class Animal
    {
        public String Name;
        public void SetName(String name)
        {
            Name = name;
        }
        public void GetName()
        {
            return Name;
        }
        public abstract void Eat();
     }

    class dog:Animal
    {
        public override void Eat()
        {
            throw new NotImplementedException();
            Console.WriteLine("the dog is eating");
        }

    }
    class prog2
    {
        public static void Main(String[] args)
        {
            dog a1 = new dog();
            a1.SetName("dummy");
            Console.WriteLine(a1.GetName());
            a1.Eat();
         
        }
    }
}


