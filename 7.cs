using System;
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string MobileNumber { get; set; }

    public virtual void GetData()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}, Mobile Number: {MobileNumber}");
    }
    public virtual void PrintData()
    {
        Console.WriteLine($"Student Information:\nName: {Name}, Age: {Age}, Address: {Address}, Mobile Number: {MobileNumber}");
    }
}
class StudentMark : Student
{
    public int Marks { get; set; }
    public override void GetData()
    {
        base.GetData();
        Console.WriteLine($"Marks: {Marks}");
    }
    public override void PrintData()
    {
        base.PrintData();
        Console.WriteLine($"Marks: {Marks}");
    }
    public char CalculateGrade()
    {
        if (Marks >= 90) return 'A';
        else if (Marks >= 75) return 'B';
        else if (Marks >= 50) return 'C';
        else return 'F';
    }
}
class Program
{
    static void Main(string[] args)
    {
        StudentMark student = new StudentMark();

        Console.Write("Enter the student's name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter the student's age: ");
        student.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter the student's address: ");
        student.Address = Console.ReadLine();

        Console.Write("Enter the student's mobile number: ");
        student.MobileNumber = Console.ReadLine();

        Console.Write("Enter the student's marks: ");
        student.Marks = int.Parse(Console.ReadLine());

        student.GetData();
        student.PrintData();
        Console.WriteLine($"Grade: {student.CalculateGrade()}");
    }
}