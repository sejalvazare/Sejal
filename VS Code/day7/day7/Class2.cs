﻿using System;
using System.Collections.Generic;
using System.Text;

namespace day7
{
    public struct Employee
    {
        public int employeeId;
        public string employeeName;
        public string address;

        public void GetData()
        {
            Console.WriteLine("Please enter employee Name");
            employeeName = Console.ReadLine();
            Console.WriteLine("Please enter employee ID");
            employeeId = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("Employee Details are :");
            Console.WriteLine("EmployeeID : {0} Employee Name {1} ", employeeId, employeeName);
        }
    };
    class Class2
    {
        public static void Main3()
        { 
           Employee e=new Employee();
            e.address = "Hi";
            e.GetData();
            e.Print();
        }
    }
}

