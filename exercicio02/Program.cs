/*
    ATIVIDADE 02

    Peça um número e retorne se é par ou ímpar.

    DICA:
    Para sabermos se um número é par ou ímpar, utilizamos o
    módulo (resto da divisão -> %).
*/

// Entrada de dados
Console.WriteLine("Informe o número:");
int numero01 = Convert.ToInt16(Console.ReadLine());

// Processamento e saída
if (numero01 % 2 == 0)
{
    Console.WriteLine($"O número {numero01} é par");
}
else
{
    Console.WriteLine($"O número {numero01} é ímpar");
}

// Versão utilizando operador ternário
Console.WriteLine(
    numero01 % 2 == 0
        ? $"O número {numero01} é par"
        : $"O número {numero01} é ímpar"
);
