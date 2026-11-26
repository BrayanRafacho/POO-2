using System.Globalization;

static double LerDouble(string mensagem)
{
}
while (true)
{
    Console.Write(mensagem);
    string texto = (Console.ReadLine() ?? "").Trim().Replace('.', ',');
    if (double.TryParse(texto, NumberStyles.Float, PtBr, out double valor))
        return valor;
    Console.WriteLine("Valor inválido. Use números, ex.: 1234,56");
}
static int LerInt(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);
        if (int.TryParse(Console.ReadLine(), out int valor) && valor >= 0)
            return valor;
        Console.WriteLine("Digite um número inteiro válido (>= 0).");
    }
    static string LerTexto(string mensagem)
    {
        Console.Write(mensagem);
        return Console.ReadLine() ?? "";
    }
    static DateTime LerDataHora(string mensagem, string formato)
    {
        while (true)
        {
            Console.Write(mensagem);
            string texto = (Console.ReadLine() ?? "").Trim();
            if (DateTime.TryParseExact(texto, formato, PtBr, DateTimeStyles.None, out DateTime data))
                return data;
            Console.WriteLine($"Data inválida. Use o formato {formato}.");
        }
    }