/*
    ATIVIDADE 13

    Peça diversos números inteiros até que seja informado o número zero.
    Ao final, exiba a soma dos valores informados.
*/

// Declaração de variáveis
int soma = 0;
int numero = 0;

// Entrada e processamento
do
{
    Console.WriteLine("Informe um número (para sair informe 0):");
    numero = int.Parse(Console.ReadLine());
    soma += numero;
}
while (numero != 0);

// Saída
Console.WriteLine($"A soma dos números é: {soma}");
