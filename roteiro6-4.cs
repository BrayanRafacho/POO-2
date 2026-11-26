static void Exercicio1B()
{
    Console.WriteLine("--- 1b) Calculadora de investimento ---");
    double capital = LerDouble("Capital inicial (R$): ");
    double taxa = LerDouble("Taxa de juros mensal (%): ");
    int meses = LerInt("Número de meses: ");
    double meta = LerDouble("Meta de lucro (R$): ");
    // Montante = capital * (1 + taxa)^meses
    double montante = capital * Math.Pow(1 + taxa / 100, meses);
    double lucro = Math.Round(montante - capital, 2);
    Console.WriteLine();
    Console.WriteLine($"Montante final: {montante:C2}");
    Console.WriteLine($"Lucro.........: {lucro:C2}");
    Console.WriteLine($"Meta..........: {meta:C2}");
    if (lucro > meta)
        Console.WriteLine("Parabéns! O lucro SUPERA a meta definida.");
    else
        Console.WriteLine("O lucro NÃO supera a meta definida.");
}