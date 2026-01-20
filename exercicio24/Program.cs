/*
    ATIVIDADE 24

    Peça cinco números inteiros.
    Exiba a média e quais números são maiores ou iguais à média.
*/

// Declaração de variáveis
int[] numeros = new int[5];
double media = 0;

// Entrada e processamento
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Informe um número: ");
    numeros[i] = int.Parse(Console.ReadLine());
    media += numeros[i];
}

media /= numeros.Length;

// Saída
Console.WriteLine($"A média dos números foi {media}");

foreach (int numero in numeros)
{
    if (numero >= media)
    {
        Console.WriteLine($"O número {numero} é maior ou igual à média {media}");
    }
}
