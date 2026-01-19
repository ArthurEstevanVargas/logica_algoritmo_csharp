/*
    ATIVIDADE 11

    Peça um número inteiro, em seguida retorne a tabuada.
*/

// Variável
int auxiliar = 0;

// Obter o número
Console.WriteLine("Informe um número:");
int numero = int.Parse(Console.ReadLine());

// Laço de repetição enquanto
while (auxiliar <= 10)
{
    Console.WriteLine($"{numero}x{auxiliar}={numero*auxiliar}");
    auxiliar++;
}