/*
    ATIVIDADE 26

    Crie uma matriz 3x3 e retorne a soma dos valores.
*/

// Declaração da matriz
int[,] numeros =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int soma = 0;

// Processamento
for (int z = 0; z < 3; z++)
{
    for (int x = 0; x < 3; x++)
    {
        soma += numeros[z, x];
    }
}

// Saída
Console.WriteLine($"A soma da matriz é {soma}");
