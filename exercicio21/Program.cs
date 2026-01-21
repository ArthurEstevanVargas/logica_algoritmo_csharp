/*
    ATIVIDADE 21

    Crie um vetor contendo 5 números inteiros.

    Calcule e exiba a soma de todos
    os valores armazenados no vetor.
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
    int[] numeros = { 1, 2, 3, 4, 5 };
    int soma = 0;

    foreach (int numero in numeros)
    {
        soma += numero;
    }

    Console.WriteLine($"A soma dos valores é {soma}");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 21");
    Console.WriteLine("Crie um vetor com 5 números inteiros.");
    Console.WriteLine("Exiba a soma dos valores.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
