﻿using System;
using System.Collections.Generic;
using System.Text;

namespace day7
{
    struct Student
    {
        private int StudId;
        private string StudName;
        public void GetData()
        {
            Console.WriteLine("Please enter Student Name");
            StudName = Console.ReadLine();
            Console.WriteLine("Please enter Student ID");
            StudId = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.WriteLine("Student Details are :");
            Console.WriteLine("Student ID : {0} Student Name: {1} ", StudId, StudName);
        }
    };
    class Class3
    {
        static void Main4(string[] args)
        {
            Student s = new Student();
            s.GetData();
            s.ShowData();
        }
    }
}
