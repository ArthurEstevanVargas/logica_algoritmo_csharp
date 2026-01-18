/*
    Peça um número e retorne se é par ou ímpar

    DICA: Para sabermos se um número é par ou ímpar, será necessário
    utilizarmos o módulo (resto da divisão -> %)
*/

// Obter o primeiro número
Console.WriteLine("Informe o primeiro número: ");
int numero01 = Convert.ToInt16(Console.ReadLine());

// Condicional
if (numero01 % 2 == 0)
{
    Console.WriteLine($"O número {numero01} é par");
} else
{
    Console.WriteLine($"O número {numero01} é ímpar");
}

// Operador ternário
Console.WriteLine(numero01 % 2 == 0 ? $"O número {numero01} é par" : $"O número {numero01} é ímpar");