using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[3];
        double[] precos = new double[3];
        int[] quantidades = new int[3];
        double subtotal = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\nNome do produto {i + 1}: ");
            nomes[i] = Console.ReadLine()!;

            Console.Write("Preço: R$ ");
            precos[i] = double.Parse(Console.ReadLine()!);

            Console.Write("Quantidade: ");
            quantidades[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("\n--------------- NOTA FISCAL ---------------");
        Console.WriteLine("{0,-15} {1,10} {2,8} {3,12}",
            "Produto", "Preço", "Qtd.", "Total");

        for (int i = 0; i < 3; i++)
        {
            double totalItem = precos[i] * quantidades[i];
            subtotal += totalItem;

            Console.WriteLine("{0,-15} {1,10:C2} {2,8:N0} {3,12:C2}",
                nomes[i], precos[i], quantidades[i], totalItem);
        }

        double desconto = subtotal * 0.10;
        double totalFinal = subtotal - desconto;

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"Subtotal: {subtotal:C2}");
        Console.WriteLine($"Desconto (10%): {desconto:C2}");
        Console.WriteLine($"Percentual de desconto: {0.10:P0}");
        Console.WriteLine($"Total final: {totalFinal:C2}");
    }
}