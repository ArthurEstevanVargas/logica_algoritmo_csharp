/*
    ATIVIDADE 26

    Crie uma matriz 3x3.

    Preencha a matriz com valores inteiros
    e calcule a soma de todos os elementos.
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
    int[,] numeros =
    {
        {1,2,3},
        {4,5,6},
        {7,8,9}
    };

    int soma = 0;

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            soma += numeros[i, j];
        }
    }

    Console.WriteLine($"A soma da matriz é {soma}");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 26");
    Console.WriteLine("Crie uma matriz 3x3.");
    Console.WriteLine("Calcule a soma de todos os valores.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro válido: "); }
    }
}
