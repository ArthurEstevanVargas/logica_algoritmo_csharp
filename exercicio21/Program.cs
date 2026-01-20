/*
    ATIVIDADE 21

    Crie um vetor contendo 5 números inteiros, percorra o vetor e retorne soma dos valores.
*/

int soma = 0;
int[] numeros = {1,2,3,4,5};

foreach (int numero in numeros)
{
    soma += numero;
}

Console.WriteLine($"A soma dos valores é de {soma}");