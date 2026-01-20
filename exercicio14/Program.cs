/*
    ATIVIDADE 14

    Peça dois números e exiba os valores entre eles.

    Exemplo:
    Entrada: 2 e 5
    Saída: 2 3 4 5
*/

// Declaração de variável auxiliar
int auxiliar;

// Entrada de dados
Console.WriteLine("Informe o primeiro número:");
int numero01 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número:");
int numero02 = int.Parse(Console.ReadLine());

// Ajuste de ordem
if (numero01 > numero02)
{
    auxiliar = numero02;
    numero02 = numero01;
    numero01 = auxiliar;
}

// Processamento e saída
do
{
    Console.WriteLine(numero01);
    numero01++;
}
while (numero01 <= numero02);
