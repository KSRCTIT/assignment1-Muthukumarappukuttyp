using System;

class EligibilityCheck
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.Write("Enter your 10th std percentage: ");
        double passPercentage = double.Parse(Console.ReadLine());
        
        if (age > 18 && age <= 30 && passPercentage >= 65)
        {
            Console.WriteLine("He is eligible");
        }
        else
        {
            Console.WriteLine("He is not eligible");
        }
    }
}
