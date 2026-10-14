using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Digite o CPF: ");
        string cpf = Console.ReadLine()!.Trim();

        cpf = cpf.Replace(".", "")
                 .Replace("-", "")
                 .Replace(" ", "");

        if (cpf.Length == 11 && cpf.All(char.IsDigit))
        {
            if (cpf.StartsWith("0") ||
                cpf.StartsWith("1") ||
                cpf.StartsWith("2") ||
                cpf.StartsWith("3") ||
                cpf.StartsWith("4") ||
                cpf.StartsWith("5") ||
                cpf.StartsWith("6") ||
                cpf.StartsWith("7") ||
                cpf.StartsWith("8") ||
                cpf.StartsWith("9"))
            {
                string formatado =
                    cpf.Substring(0, 3) + "." +
                    cpf.Substring(3, 3) + "." +
                    cpf.Substring(6, 3) + "-" +
                    cpf.Substring(9, 2);

                Console.WriteLine($"CPF formatado: {formatado}");
            }
        }
        else
        {
            Console.WriteLine("CPF inválido: informe exatamente 11 dígitos.");
        }
    }
}