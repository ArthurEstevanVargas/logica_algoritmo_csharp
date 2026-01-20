/*
    ATIVIDADE 01

    Peça dois números inteiros, se forem iguais realize a soma, se forem
    diferentes realize a multiplicação
*/

Console.WriteLine("Informe o primeiro número: ");
int numero01 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
int numero02 = Convert.ToInt16(Console.ReadLine());

if (numero01 == numero02)
{
    Console.WriteLine($"A soma dos números é {numero01 + numero02}");
} else
{
    Console.WriteLine($"A multiplicação dos números é {numero01 * numero02}");
}

Console.WriteLine(numero01 == numero02 ? $"A soma dos números é {numero01 + numero02}" : $"A multiplicação dos números é {numero01 * numero02}");