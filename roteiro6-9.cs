static void ExercicioIntegrador()
{
    Console.WriteLine("--- Cadastro de evento ---");
    string nome = LerTexto("Nome do evento: ").Trim();
    DateTime dataEvento = LerDataHora("Data do evento (dd/MM/yyyy): ", "dd/MM/yyyy");
    double valor = LerDouble("Valor do ingresso (R$): ");
    string categoria;
    while (true)
    {
        string digitado = LerTexto("Categoria (VIP/Comum): ").Trim().ToUpper();
        if (digitado.Contains("VIP")) { categoria = "VIP"; break; }
        if (digitado.Contains("COMUM")) { categoria = "COMUM"; break; }
        Console.WriteLine("Categoria inválida. Digite VIP ou Comum.");
    }
    int dias = (dataEvento.Date - DateTime.Today).Days;

    double percentual = dias >= 30 ? 0.15 : dias >= 7 ? 0.05 : 0.0;
    double valorFinal = Math.Round(valor * (1 - percentual), 2);
    string linha = "+" + new string('=', 42) + "+";
    Console.WriteLine();
    Console.WriteLine(linha);
    Console.WriteLine(string.Format("| {0,-18}{1,22} |", "INGRESSO", categoria));
    Console.WriteLine(linha);
    Console.WriteLine(string.Format("| {0,-14}{1,26} |", "Evento:", nome));
    Console.WriteLine(string.Format("| {0,-14}{1,26:dd/MM/yyyy} |", "Data:", dataEvento));
    Console.WriteLine(string.Format("| {0,-14}{1,26} |", "Dias restantes:", dias));
    Console.WriteLine(string.Format("| {0,-14}{1,26:C} |", "Valor original:", valor));
    Console.WriteLine(string.Format("| {0,-14}{1,26:P0} |", "Desconto:", percentual));
    Console.WriteLine(string.Format("| {0,-14}{1,26:C} |", "VALOR FINAL:", valorFinal));
    Console.WriteLine(linha);
    if (dias < 0)
        Console.WriteLine("(Atenção: esse evento já aconteceu.)");
}