/*
    ATIVIDADE 29

    Crie uma matriz 5x5 contendo números inteiros.

    Calcule e exiba:
    - A soma total dos elementos
    - A soma da diagonal principal
    - A soma da diagonal secundária
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
        { 5, 1, 4, 1, 1 },
        { 2, 7, 2, 3, 2 },
        { 2, 3, 9, 3, 5 },
        { 4, 9, 4, 8, 4 },
        { 1, 5, 6, 5, 5 }
    };

    int somaTotal = 0;
    int somaDiagonalPrincipal = 0;
    int somaDiagonalSecundaria = 0;

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            somaTotal += numeros[i, j];

            if (i == j)
            {
                somaDiagonalPrincipal += numeros[i, j];
            }

            if (i + j == 4)
            {
                somaDiagonalSecundaria += numeros[i, j];
            }
        }
    }

    Console.WriteLine($"Soma total: {somaTotal}");
    Console.WriteLine($"Diagonal principal: {somaDiagonalPrincipal}");
    Console.WriteLine($"Diagonal secundária: {somaDiagonalSecundaria}");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 29");
    Console.WriteLine("Crie uma matriz 5x5.");
    Console.WriteLine("Exiba a soma total e das diagonais.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro válido: "); }
    }
}
