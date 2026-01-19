/*
    ATIVIDADE 05

    Peça um ano e retorne se é bissexto ou não.

    DICA: Um ano bissexto ocorre a cada 4 anos.
*/

// Obter um ano
Console.WriteLine("Informe um ano");
int ano = int.Parse(Console.ReadLine());

// Condicional - ano bissexto 
if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
{
    Console.WriteLine("O ano é bissexto");
} else if (ano % 100 == 0)
{
    Console.WriteLine("O ano não é bissexto");
}