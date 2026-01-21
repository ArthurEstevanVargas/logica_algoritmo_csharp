/*
    ATIVIDADE 23

    Solicite ao usuário cinco nomes.

    Armazene os nomes em um vetor
    e exiba todos os valores informados.
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
    string[] nomes = new string[5];

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.Write("Informe um nome: ");
        nomes[i] = Console.ReadLine();
    }

    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 23");
    Console.WriteLine("Solicite cinco nomes ao usuário.");
    Console.WriteLine("Armazene em um vetor e exiba os nomes.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
