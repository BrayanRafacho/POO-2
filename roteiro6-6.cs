static void Exercicio2B()
{
    Console.WriteLine("--- 2b) Validação de CPF ---");
    string entrada = LerTexto("Digite o CPF (pode ter pontos, traços e espaços): ");

    string cpf = entrada.Trim()
                        .Replace(".", "")
                        .Replace("-", "")
                        .Replace(" ", "");
    bool soDigitos = cpf.Length > 0;
    foreach (char c in cpf)
    {
        if (!char.IsDigit(c)) { soDigitos = false; break; }
    }
    if (!soDigitos)
    {
        Console.WriteLine("CPF inválido: contém caracteres que não são dígitos.");
        return;
    }
    if (cpf.Length != 11)
    {
        Console.WriteLine($"CPF inválido: precisa ter 11 dígitos (tem {cpf.Length}).");
        return;
    }
 
    bool comecaComDigito = false;
    for (int d = 0; d <= 9; d++)
    {
        if (cpf.StartsWith(d.ToString())) { comecaComDigito = true; break; }
    }
    if (!comecaComDigito)
    {
        Console.WriteLine("CPF inválido: não começa com um dígito válido.");
        return;
    }
    string formatado = cpf.Substring(0, 3) + "." +
                       cpf.Substring(3, 3) + "." +
                       cpf.Substring(6, 3) + "-" +
                       cpf.Substring(9, 2);
    Console.WriteLine($"CPF formatado: {formatado}");
}