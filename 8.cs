using System;
class Employee
{
    public int JobCategory { get; set; }
    public int EmpNo { get; set; }
    public string EmpName { get; set; }
    public double BasicSalary { get; set; }
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Loan { get; set; }
    public double PF { get; set; }
    
    public Employee(int jobCategory)
    {
        JobCategory = jobCategory;
        if (JobCategory == 1)
        {
            BasicSalary = 8000;
            HRA = 0.1 * BasicSalary;
            DA = 0.2 * BasicSalary;
            Loan = 300;
            PF = 500;
        }
        else if (JobCategory == 2)
        {
            BasicSalary = 15000;
            HRA = 0.2 * BasicSalary;
            DA = 0.3 * BasicSalary;
            Loan = 600;
            PF = 1000;
        }
    }
    public void InputDetails(int empNo, string empName)
    {
        EmpNo = empNo;
        EmpName = empName;
    }
    public double CalculateSalary()
    {
        return BasicSalary + HRA + DA - (Loan + PF);
    }
    public void Display()
    {
        Console.WriteLine($"\nEmployee No: {EmpNo}");
        Console.WriteLine($"Employee Name: {EmpName}");
        Console.WriteLine($"Job Category: {JobCategory}");
        Console.WriteLine($"Basic Salary: {BasicSalary}");
        Console.WriteLine($"HRA: {HRA}");
        Console.WriteLine($"DA: {DA}");
        Console.WriteLine($"Loan Deduction: {Loan}");
        Console.WriteLine($"PF Deduction: {PF}");
        Console.WriteLine($"Net Salary: {CalculateSalary()}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Job Category (1 or 2): ");
        int jobCategory = int.Parse(Console.ReadLine());

        Employee emp = new Employee(jobCategory);

        Console.Write("Enter Employee Number: ");
        int empNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string empName = Console.ReadLine();

        emp.InputDetails(empNo, empName);

        emp.Display();
    }
}