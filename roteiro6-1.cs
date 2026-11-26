using System.Globalization;
using System.Text;

static void Main()
{
    Console.OutputEncoding = Encoding.UTF8;
    CultureInfo.CurrentCulture = PtBr;
    CultureInfo.DefaultThreadCurrentCulture = PtBr;
    while (true)
    {
        Console.WriteLine("\n===== CLASSES UTILITÁRIAS =====");
        Console.WriteLine("1a - Math: arredondamentos");
        Console.WriteLine("1b - Math: calculadora de investimento");
        Console.WriteLine("2a - String: operações com frase");
        Console.WriteLine("2b - String: validação e formatação de CPF");
        Console.WriteLine("3a - Formatação: tabela de produtos");
        Console.WriteLine("4  - Datas: compromisso");
        Console.WriteLine("5  - Integrador: cadastro de evento");
        Console.WriteLine("0  - Sair");
        Console.Write("Escolha: ");
        string opcao = (Console.ReadLine() ?? "").Trim().ToLower();
        Console.WriteLine();
        switch (opcao)
        {
            case "1a": Exercicio1A(); break;
            case "1b": Exercicio1B(); break;
            case "2a": Exercicio2A(); break;
            case "2b": Exercicio2B(); break;
            case "3a": Exercicio3A(); break;
            case "4": Exercicio4(); break;
            case "5": ExercicioIntegrador(); break;
            case "0": return;
            default: Console.WriteLine("Opção inválida."); break;
        }
    }
}