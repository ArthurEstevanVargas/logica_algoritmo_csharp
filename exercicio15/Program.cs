/*
    ATIVIDADE 15

    Será gerado aleatóriamente um número entre 1 e 10.
    Enquanto o usuário não acertar o número, peça pra informar um valor.
*/

// Gerar número aleatório
Random random = new Random();

// Armazenar um número aleatório entre 1 e 10;
int numeroaleatorio = random.Next(1,10);
int numeroinformado = 0;

Console.WriteLine(numeroaleatorio);

// Laço de repetição enquanto
do
{
    Console.WriteLine("Informe um número entre 1 e 10:");
    numeroinformado = int.Parse(Console.ReadLine());
} while (numeroinformado != numeroaleatorio);