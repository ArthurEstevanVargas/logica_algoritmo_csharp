/*
    ATIVIDADE 13

    Peça diversos números inteiros, até que seja informado o número zero.

    Quando sair da estrutura de repetição, exiba a soma dos valores informados.

    Exemplo 7,8,10 e 0.

    A soma será 25.
*/

int soma = 0;
int numero = 0;

do
{
    Console.WriteLine("Informe um número (para sair informe 0):");
    numero = int.Parse(Console.ReadLine());
    soma += numero;
} while (numero != 0);

Console.WriteLine($"A soma dos números é: {soma}");