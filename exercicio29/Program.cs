/*
    ATIVIDADE 29

    Matriz 5x5.
    Retorne:
    - Soma total
    - Soma da diagonal principal
    - Soma da diagonal secundária
*/

// Declaração da matriz
int[,] numeros =
{
    { 5, 1, 4, 1, 1 },
    { 2, 7, 2, 3, 2 },
    { 2, 3, 9, 3, 5 },
    { 4, 9, 4, 8, 4 },
    { 1, 5, 6, 5, 5 }
};

int soma = 0;
int somadiagonalprincipal = 0;
int somadiagonalsecundaria = 0;

// Processamento
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

// Saída
Console.WriteLine(soma);
Console.WriteLine(somadiagonalprincipal);
Console.WriteLine(somadiagonalsecundaria);
