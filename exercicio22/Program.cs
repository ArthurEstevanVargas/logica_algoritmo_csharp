/*
    ATIVIDADE 22

    Crie um vetor contendo 5 nomes.

    Solicite ao usuário um nome e verifique
    se ele existe dentro do vetor.

    Informe o resultado da busca.
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
    string[] nomes = { "Arthur", "Pedro", "João", "Maria", "Bruno" };

    Console.Write("Informe um nome: ");
    string nome = Console.ReadLine();

    bool encontrado = false;

    foreach (string item in nomes)
    {
        if (item == nome)
        {
            encontrado = true;
            break;
        }
    }

    Console.WriteLine(encontrado
        ? "O nome está na lista."
        : "O nome não está na lista.");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 22");
    Console.WriteLine("Crie um vetor com 5 nomes.");
    Console.WriteLine("Verifique se um nome informado existe no vetor.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
