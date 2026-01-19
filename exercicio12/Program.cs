/*
    ATIVIDADE 12

    Peça um nome até que seja informado o termo "sair".
*/

// Variável
string ?texto;

// Laço de repetição enquanto
do
{
    Console.WriteLine($"O unico jeito de sair é digitando sair.");
    texto = Console.ReadLine();
} while (texto != "sair");