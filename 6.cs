using System;
class Vector
{
    public int X { get; set; }
    public int Y { get; set; }
    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }
    public static Vector operator +(Vector a, Vector b)
    {
        return new Vector(a.X + b.X, a.Y + b.Y);
    }
    public void Display()
    {
        Console.WriteLine($"Vector: ({X}, {Y})");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter X coordinate for first vector: ");
        int x1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Y coordinate for first vector: ");
        int y1 = int.Parse(Console.ReadLine());

        Vector v1 = new Vector(x1, y1);

        Console.Write("Enter X coordinate for second vector: ");
        int x2 = int.Parse(Console.ReadLine());

        Console.Write("Enter Y coordinate for second vector: ");
        int y2 = int.Parse(Console.ReadLine());

        Vector v2 = new Vector(x2, y2);
        Vector v3 = v1 + v2;
        v3.Display();
    }
}