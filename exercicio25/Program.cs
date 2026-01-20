/*
    ATIVIDADE 25

    Peça cinco números inteiros.
    Exiba as posições onde o número 5 aparece.
    Caso não exista, informe que não foi encontrado.
*/

// Declaração de variáveis
int[] numeros = new int[5];
bool auxiliar = false;

// Entrada de dados
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Informe um número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

// Processamento
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == 5)
    {
        Console.WriteLine($"O número 5 está na posição {i + 1}");
    }
    else
    {
        auxiliar = false;
    }
}

// Saída
if (!auxiliar)
{
    Console.WriteLine("O número 5 não foi encontrado");
}
