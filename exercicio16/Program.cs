/*
    ATIVIDADE 16

    Peça um número inteiro, em seguida crie uma estrutura de repetição
    que deverá iniciar pelo número 1 e finalizar pelo número informado.

    Retorne a quantidade de números pares e ímpares entre os valores.

    Exemplo: Se informado o número 5, o laço irá percorrer os valores
    1, 2, 3, 4 e 5

    Retornando 2 pares e 3 ímpares.
*/

// Variável
int auxiliar = 1;
int numerospar = 0;
int numerosimpar = 0;

// Obter número inteiro
Console.WriteLine("Informe um número:");
int numero = int.Parse(Console.ReadLine());

// Laço de repetição enquanto
do
{
    Console.WriteLine(auxiliar);
    if (auxiliar % 2 == 0)
    {
        numerospar++;
    } else
    {
        numerosimpar++;
    }
    auxiliar++;
} while (auxiliar <= numero);

Console.WriteLine($"A quantidade de números par foi {numerospar} e a de números ímpar {numerosimpar}");