/*
    ATIVIDADE 25

    Peça cinco números inteiros e armazene cada um no vetor.

    Depois de armazenar os valores, exiba cada posição, onde o número
    seja igual a cinco.

    Caso não seja informado nenhum número 5,
    retorne: "O número 5 não foi encontrado"
*/

int[] numeros = new int[5];
bool auxiliar = false;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Informe um número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == 5)
    {
        Console.WriteLine($"O número 5 está na posição {i+1}");
    } else
    {
        auxiliar = false;
    }
}

if (!auxiliar)
{
    Console.WriteLine("O número 5 não foi encontrado");
}