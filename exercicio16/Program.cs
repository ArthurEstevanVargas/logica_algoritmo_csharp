/*
    ATIVIDADE 15

    Será gerado aleatoriamente um número entre 1 e 10.
    Enquanto o usuário não acertar, solicite novos valores.
*/

// Geração de número aleatório
Random random = new Random();
int numeroaleatorio = random.Next(1, 10);
int numeroinformado = 0;

// Exibição do número (modo teste)
Console.WriteLine(numeroaleatorio);

// Estrutura de repetição
do
{
    Console.WriteLine("Informe um número entre 1 e 10:");
    numeroinformado = int.Parse(Console.ReadLine());
}
while (numeroinformado != numeroaleatorio);
