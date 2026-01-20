/*
    ATIVIDADE 12

    Peça um nome até que seja informado o termo "sair".
*/

string ?texto;

do
{
    Console.WriteLine($"O unico jeito de sair é digitando sair.");
    texto = Console.ReadLine();
} while (texto != "sair");