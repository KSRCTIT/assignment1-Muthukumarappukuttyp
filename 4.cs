using System;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }

    public void PrintPerson()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight}");
    }
}
class PersonData
{
    static void Main(string[] args)
    {
        Person person = new Person();
        Console.Write("Enter Name: ");
        person.Name = Console.ReadLine();

        Console.Write("Enter Age: ");
        person.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter Weight: ");
        person.Weight = double.Parse(Console.ReadLine());
        person.PrintPerson();
    }
}