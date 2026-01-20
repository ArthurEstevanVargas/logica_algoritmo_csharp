/*
    ATIVIDADE 28

    Utilizando a estrutura random, gere valores entre 0 e 9
    e cadastre em uma matriz 5x5.

    Quando a matriz for devidamente preenchida, exiba a estrutura dela.
*/

int[,] numeros = new int[5,5];

for (int z = 0; z < 5; z++)
{
    for (int x = 0; x < 5; x++)
    {
        Random random = new Random();
        int numeroaleatorio = random.Next(0,10);
        numeros[z,x] = numeroaleatorio;
        Console.Write(numeros[z,x] + " ");
    }
    Console.WriteLine();
}