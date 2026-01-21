/*
    ATIVIDADE 28

    Gere números aleatórios entre 0 e 9.

    Armazene os valores em uma matriz 5x5
    e exiba o conteúdo da matriz.
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
    int[,] numeros = new int[5, 5];
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            numeros[i, j] = random.Next(0, 10);
            Console.Write(numeros[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 28");
    Console.WriteLine("Gere valores aleatórios entre 0 e 9.");
    Console.WriteLine("Armazene em uma matriz 5x5.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro válido: "); }
    }
}
