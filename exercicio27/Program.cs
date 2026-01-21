/*
    ATIVIDADE 27

    Crie uma matriz 3x2 para armazenar:

    - Nome
    - E-mail

    Após o preenchimento, exiba
    todas as informações cadastradas.
*/

Menu();

static void Menu()
{
    int opcao;
    do
    {
        Console.WriteLine("1 - Descrição");
        Console.WriteLine("2 - Executar exercício");
        Console.WriteLine("0 - Sair");

        opcao = LerInteiro();

        switch (opcao)
        {
            case 1: MostrarDescricao(); break;
            case 2: Executar(); break;
        }
    } while (opcao != 0);
}

static void Executar()
{
    string[,] informacoes = new string[3, 2];

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Pessoa {i + 1}");

        Console.Write("Nome: ");
        informacoes[i, 0] = Console.ReadLine();

        Console.Write("Email: ");
        informacoes[i, 1] = Console.ReadLine();
    }

    Console.WriteLine("\nDados cadastrados:");
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Nome: {informacoes[i, 0]} | Email: {informacoes[i, 1]}");
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 27");
    Console.WriteLine("Crie uma matriz 3x2 para nome e e-mail.");
    Console.WriteLine("Exiba todas as informações cadastradas.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro válido: "); }
    }
}
