/*
    ATIVIDADE 21

    Crie um vetor com 5 números inteiros
    e retorne a soma dos valores.
*/

// Declaração de variáveis
int soma = 0;
int[] numeros = { 1, 2, 3, 4, 5 };

// Processamento
foreach (int numero in numeros)
{
    soma += numero;
}

// Saída
Console.WriteLine($"A soma dos valores é de {soma}");
