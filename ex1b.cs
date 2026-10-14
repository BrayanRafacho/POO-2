using System;

class Program
{
    static void Main()
    {
        Console.Write("Capital inicial: R$ ");
        double capital = double.Parse(Console.ReadLine()!);

        Console.Write("Taxa de juros mensal (%): ");
        double taxa = double.Parse(Console.ReadLine()!) / 100;

        Console.Write("Número de meses: ");
        int meses = int.Parse(Console.ReadLine()!);

        Console.Write("Meta de lucro: R$ ");
        double meta = double.Parse(Console.ReadLine()!);

        double montante = capital * Math.Pow(1 + taxa, meses);
        double lucro = montante - capital;
        double lucroArredondado = Math.Round(lucro, 2);

        Console.WriteLine($"\nMontante final: R$ {montante:F2}");
        Console.WriteLine($"Lucro: R$ {lucroArredondado:F2}");

        if (lucroArredondado > meta)
            Console.WriteLine("A meta de lucro foi superada!");
        else
            Console.WriteLine("A meta de lucro não foi superada.");
    }
}