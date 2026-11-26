static void Exercicio3A()
{
}
Console.WriteLine("--- 3a) Tabela de produtos ---");
string[] nomes = { "Caneta", "Caderno", "Mochila" };
double[] precos = { 3.5, 25.9, 189.9 };
int[] quantidades = { 1200, 15, 3 };
double subtotal = 0;
Console.WriteLine(string.Format("{0,-12}{1,12}{2,8}{3,16}", "Produto", "Preço", "Qtd", "Total"));
Console.WriteLine(new string('-', 48));
for (int i = 0; i < nomes.Length; i++)
{
    double totalItem = precos[i] * quantidades[i];
    subtotal += totalItem;
    Console.WriteLine(string.Format("{0,-12}{1,12:C}{2,8:N0}{3,16:C}",
        nomes[i], precos[i], quantidades[i], totalItem));
}
double percentualDesconto = 0.10;
double desconto = subtotal * percentualDesconto;
double totalFinal = subtotal - desconto;
Console.WriteLine(new string('-', 48));
Console.WriteLine(string.Format("{0,-32}{1,16:C}", "Subtotal:", subtotal));
Console.WriteLine(string.Format("{0,-32}{1,16:C}", $"Desconto ({percentualDesconto:P0}):", -desconto));
Console.WriteLine(string.Format("{0,-32}{1,16:C}", "TOTAL FINAL:", totalFinal));
Console.WriteLine($"\nValor final (F2): {totalFinal:F2}");

}