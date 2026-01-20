/*
    ATIVIDADE 12

    Peça um nome até que seja informado o termo "sair".
*/

// Declaração de variável
string? texto;

// Estrutura de repetição
do
{
    Console.WriteLine("O único jeito de sair é digitando sair.");
    texto = Console.ReadLine();
}
while (texto != "sair");
