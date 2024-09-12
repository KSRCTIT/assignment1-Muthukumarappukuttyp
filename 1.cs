using System;

class Program
{
    static void Main()
    {

        int[,] array = { { 10,20,30 }, { 40,50,60 }, { 70,80,90 } };
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
        }
    }
}
