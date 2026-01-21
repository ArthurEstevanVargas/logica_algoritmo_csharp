/*
    ATIVIDADE 19

    Gere e exiba 5 números aleatórios
    entre 1 e 30.

    Para cada número, informe
    se ele é par ou ímpar.
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
            case 0: break;
        }
    } while (opcao != 0);
}

static void Executar()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        int numero = random.Next(1, 31);
        string tipo = numero % 2 == 0 ? "Par" : "Ímpar";
        Console.WriteLine($"{numero} - {tipo}");
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 19");
    Console.WriteLine("Exiba 5 números aleatórios entre 1 e 30.");
    Console.WriteLine("Informe se cada número é par ou ímpar.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
