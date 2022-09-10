using System;

namespace dot_net_day_5
{
    class Person
    {
        public int age;
            public void Greet()
        {
            Console.WriteLine("hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
    class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining on screen");
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studing on the screen");
        }

        public void ShowAge()
        {
            Console.WriteLine("my age is {0} years old ,age");
        }
    }

    class stud
        public static void main3(String[] args)
    {
        Person p = new Person();
        Person.Greet();

        Student s = new Student();
        Student.SetAge(21);
        Student.Greet();
        Student.ShowAge();
        Student.Study();

        Teacher t = new Teacher();
        Teacher.SetAge(21);
        Teacher.Greet();
        Teacher.ShowAge();
       Teacher.Explain();
    }
}

       

    

