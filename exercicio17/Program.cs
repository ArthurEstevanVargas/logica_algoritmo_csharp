/*
    ATIVIDADE 17

    Crie um sistema de votação com três candidatos.

    Permita ao usuário votar quantas vezes desejar
    e ofereça uma opção para encerrar a votação.

    Ao final, exiba a quantidade de votos
    recebida por cada candidato.
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
    int opcao;
    string[] candidatos = { "Ana", "Robson", "Evandro" };
    int[] votos = new int[3];

    do
    {
        Console.WriteLine("1 - Ana");
        Console.WriteLine("2 - Robson");
        Console.WriteLine("3 - Evandro");
        Console.WriteLine("4 - Sair");

        opcao = LerInteiro();

        switch (opcao)
        {
            case 1: votos[0]++; break;
            case 2: votos[1]++; break;
            case 3: votos[2]++; break;
        }

    } while (opcao != 4);

    Console.WriteLine("Resultado da votação:");
    for (int i = 0; i < votos.Length; i++)
    {
        Console.WriteLine($"{candidatos[i]}: {votos[i]} votos");
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 17");
    Console.WriteLine("Sistema de votação com três candidatos.");
    Console.WriteLine("Exiba o total de votos de cada um ao final.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
