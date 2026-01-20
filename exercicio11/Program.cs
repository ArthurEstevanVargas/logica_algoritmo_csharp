/*
    ATIVIDADE 11

    Peça um número inteiro, em seguida retorne a tabuada.
*/

int auxiliar = 0;

Console.WriteLine("Informe um número:");
int numero = int.Parse(Console.ReadLine());

while (auxiliar <= 10)
{
    Console.WriteLine($"{numero}x{auxiliar}={numero*auxiliar}");
    auxiliar++;
}