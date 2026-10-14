using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o {i}º número decimal: ");
            double numero = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"Original: {numero}");
            Console.WriteLine($"Round: {Math.Round(numero)}");
            Console.WriteLine($"Floor: {Math.Floor(numero)}");
            Console.WriteLine($"Ceiling: {Math.Ceiling(numero)}");
            Console.WriteLine($"Truncate: {Math.Truncate(numero)}");
            Console.WriteLine();
        }
    }
}