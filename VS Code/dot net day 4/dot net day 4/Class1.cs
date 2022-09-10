using System

    namespace day4

    class emp 
{
    int Empid;
    string EmployeeName;
    int salary;
}
public void GetData()
{
    Console.WriteLine("Please enter the employee details ");
    Empid = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter Employee name");
    EmployeeName = Console.ReadLine();
    Console.WriteLine("Please enter Employee salary");
    salary = Convert.ToInt32(Console.ReadLine());
}
public void PrintData()
{
    Console.WriteLine("Employee Details are:");
    Console.WriteLine("Employee id"  : " + Empid);
    Console.WriteLine("Employee name : " + EmployeeName);
    Console.WriteLine("Employee salary : " + salary);
}
    }