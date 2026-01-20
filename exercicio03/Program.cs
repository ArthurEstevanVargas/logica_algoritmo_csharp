/*
    ATIVIDADE 03

    Peça duas notas, em seguida realize a média e retorne a situação.

    7 - 10   : Aprovado(a)
    5 - 6.9  : Recuperação
    0 - 4.9  : Reprovado(a)
*/

// Entrada de dados
Console.WriteLine("Informe a primeira nota:");
int nota01 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Informe a segunda nota:");
int nota02 = Convert.ToInt16(Console.ReadLine());

// Processamento
double media = (nota01 + nota02) / 2;

// Saída
if (media >= 7 && media <= 10)
{
    Console.WriteLine("Aprovado(a)");
}
else if (media >= 5 && media <= 6.9)
{
    Console.WriteLine("Recuperação");
}
else if (media >= 0 && media <= 4.9)
{
    Console.WriteLine("Reprovado(a)");
}

/*
    ATIVIDADE 03 (VERSÃO COM LAÇO DE REPETIÇÃO)

    Peça duas notas, calcule a média e retorne a situação.
*/

// Declaração de variáveis
int auxiliar = 0;
double media = 0;

// Entrada de dados
for (int indice = 0; indice < 2; indice++)
{
    Console.WriteLine($"Informe a {indice}° nota:");
    auxiliar += 1;
    media += Convert.ToInt16(Console.ReadLine());
}

// Processamento
media /= auxiliar;

// Saída
if (media >= 7 && media <= 10)
{
    Console.WriteLine("Aprovado(a)");
}
else if (media >= 5 && media <= 6.9)
{
    Console.WriteLine("Recuperação");
}
else if (media >= 0 && media <= 4.9)
{
    Console.WriteLine("Reprovado(a)");
}
