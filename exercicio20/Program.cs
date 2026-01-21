/*
    ATIVIDADE 20

    Exiba 100 asteriscos (*),
    organizados em 10 linhas e 10 colunas,
    formando uma matriz visual no console.
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
    for (int i = 1; i <= 100; i++)
    {
        Console.Write(i % 10 == 0 ? "*\n" : "* ");
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 20");
    Console.WriteLine("Exiba 100 asteriscos em 10 linhas e 10 colunas.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
