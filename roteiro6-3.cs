static void Exercicio1A()
{
}
Console.WriteLine("--- 1a) Arredondamentos ---");
for (int i = 1; i <= 5; i++)
{
    double n = LerDouble($"Digite o {i}º número decimal: ");
    Console.WriteLine($"  Original............: {n}");
    Console.WriteLine($"  Math.Round..........: {Math.Round(n)}");
    Console.WriteLine($"  Math.Floor (baixo)..: {Math.Floor(n)}");
    Console.WriteLine($"  Math.Ceiling (cima).: {Math.Ceiling(n)}");
    Console.WriteLine($"  Math.Truncate.......: {Math.Truncate(n)}");
    Console.WriteLine();
}