/*
    ATIVIDADE 26

    Crie uma matriz (3x3) contendo valores númericos inteiros.

    Exiba o valor contido na matriz e a soma dos valores.
*/

int[,] numeros = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
};
int soma = 0;

for (int z = 0; z < 3; z++)
{
    for (int x = 0; x < 3; x++)
    {
        soma += numeros[z,x];
    }
}

Console.WriteLine($"A soma da matriz é {soma}");