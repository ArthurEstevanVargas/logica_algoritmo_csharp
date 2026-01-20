/*
    ATIVIDADE 28

    Gere valores aleatórios entre 0 e 9
    e armazene em uma matriz 5x5.
*/

// Declaração da matriz
int[,] numeros = new int[5, 5];

// Processamento e saída
for (int z = 0; z < 5; z++)
{
    for (int x = 0; x < 5; x++)
    {
        Random random = new Random();
        numeros[z, x] = random.Next(0, 10);
        Console.Write(numeros[z, x] + " ");
    }
    Console.WriteLine();
}
