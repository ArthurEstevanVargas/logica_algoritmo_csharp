/*
    ATIVIDADE 27

    Crie uma matriz 3x2 para armazenar nome e e-mail.
    Após o cadastro, exiba as informações.
*/

// Declaração da matriz
string?[,] informacoes = new string[3, 2];

// Entrada de dados
for (int z = 0; z < 3; z++)
{
    Console.WriteLine($"Pessoa {z + 1}");

    Console.Write("Informe o nome: ");
    informacoes[z, 0] = Console.ReadLine();

    Console.Write("Informe o email: ");
    informacoes[z, 1] = Console.ReadLine();
}

// Saída
foreach (string informacao in informacoes)
{
    Console.WriteLine(informacao);
}
