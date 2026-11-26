static void Exercicio2A()
{
}
Console.WriteLine("--- 2a) Operações com frase ---");
string frase = LerTexto("Digite uma frase com espaços nas pontas e palavras separadas por vírgula:\n> ");
string limpa = frase.Trim();
Console.WriteLine($"\nCom Trim()........: \"{limpa}\"");

string[] partes = limpa.Split(',');
Console.WriteLine("Com Split(','):");
for (int i = 0; i < partes.Length; i++)
    Console.WriteLine($"  [{i}] \"{partes[i].Trim()}\"");

string antiga = LerTexto("\nPalavra a substituir: ").Trim();
string nova = LerTexto("Substituir por: ").Trim();
if (antiga.Length > 0)
    Console.WriteLine($"Com Replace().....: \"{limpa.Replace(antiga, nova)}\"");
else
    Console.WriteLine("Nenhuma palavra informada para substituir.");

string inicio = LerTexto("\nVerificar se a frase começa com: ").Trim();
Console.WriteLine($"StartsWith(\"{inicio}\"): {limpa.StartsWith(inicio, StringComparison.OrdinalIgnoreCase)}");
string fim = LerTexto("Verificar se a frase termina com: ").Trim();
Console.WriteLine($"EndsWith(\"{fim}\"): {limpa.EndsWith(fim, StringComparison.OrdinalIgnoreCase)}");