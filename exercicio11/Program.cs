/*
    ATIVIDADE 11

    Peça um número inteiro e retorne a tabuada.
*/

// Declaração de variáveis
int auxiliar = 0;

// Entrada de dados
Console.WriteLine("Informe um número:");
int numero = int.Parse(Console.ReadLine());

// Processamento e saída
while (auxiliar <= 10)
{
    Console.WriteLine($"{numero}x{auxiliar}={numero * auxiliar}");
    auxiliar++;
}
