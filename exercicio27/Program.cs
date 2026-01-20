/*
    ATIVIDADE 27

    Crie uma matriz (3x2) e peça para o usuário
    informar três nomes e três e-mails.

    Depois de realizar o cadastro, exiba as informações
*/

string?[,] informacoes = new string[3,2];

for (int z = 0; z < 3; z++)
{
    Console.WriteLine($"Pessoa {z + 1}");

    Console.Write("Informe o nome: ");
    informacoes[z, 0] = Console.ReadLine();

    Console.Write("Informe o email: ");
    informacoes[z, 1] = Console.ReadLine();
}

foreach (string informacao in informacoes)
{
    Console.WriteLine(informacao);
}