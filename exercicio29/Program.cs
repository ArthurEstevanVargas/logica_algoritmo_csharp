/*
    ATIVIDADE 29

    Crie uma matriz 5x5 contendo 25 números já cadastrados:
    
    5 1 4 1 1
    2 7 2 3 2
    2 3 9 3 5
    4 9 4 8 4
    1 5 6 5 5

    Retorne as seguintes informações:
    - Soma de todos os elementos da matriz
    - Soma da diagonal principal
    - Soma da diagonal secundaria
*/

int[,] numeros =
{
    {5, 1, 4, 1, 1},
    {2, 7, 2, 3, 2},
    {2, 3, 9, 3, 5},
    {4, 9, 4, 8, 4},
    {1, 5, 6, 5, 5}
};
int soma = 0;
int somadiagonalprincipal = 0;
int somadiagonalsecundaria = 0;

for (int linhas = 0; linhas < 5; linhas++)
{
    for (int colunas = 0; colunas < 5; colunas++)
    {
        soma += numeros[linhas, colunas];
        if (linhas == colunas)
        {
            somadiagonalprincipal += numeros[linhas, colunas];
        }
        if (linhas + colunas == 4)
        {
            somadiagonalsecundaria += numeros[linhas, colunas];
        }
    }
}

Console.WriteLine(soma);
Console.WriteLine(somadiagonalprincipal);
Console.WriteLine(somadiagonalsecundaria);