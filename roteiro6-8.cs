static void Exercicio4()
{
}
Console.WriteLine("--- 4) Compromisso ---");
string nome = LerTexto("Seu nome: ").Trim();
DateTime compromisso = LerDataHora("Data e hora do compromisso (dd/MM/yyyy HH:mm): ", "dd/MM/yyyy HH:mm");
int dias = (compromisso.Date - DateTime.Today).Days;
string diaSemana = PtBr.DateTimeFormat.GetDayName(compromisso.DayOfWeek);
string artigo = (compromisso.DayOfWeek == DayOfWeek.Saturday ||
                 compromisso.DayOfWeek == DayOfWeek.Sunday) ? "no" : "na";
string mensagem = string.Format(
    "Olá, {0}!\nSeu compromisso será em {1} dias, {2} {3}.\nData marcada: {4:dd/MM/yyyy} às {4:HH:mm}",
    nome, dias, artigo, diaSemana, compromisso);
Console.WriteLine();
Console.WriteLine(mensagem);
if (dias < 0)
{
    
    Console.WriteLine("(Atenção: essa data já passou.)");
}
