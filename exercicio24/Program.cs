/*
    ATIVIDADE 24

    Peça cinco números inteiros e armazene cada um no vetor.

    Exiba a média dos valores informados e quais números são maiores
    ou iguais a média.
*/

int[] numeros = new int[5];
double media = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Informe um número: ");
    numeros[i] = int.Parse(Console.ReadLine());
    media += numeros[i];
}

media = media/numeros.Length;
Console.WriteLine($"A média dos números foi {media}");

foreach (int numero in numeros)
{
    if (numero >= media)
    {
        Console.WriteLine($"O número {numero} é maior ou igual a média {media}");
    }
}