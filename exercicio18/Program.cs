/*
    ATIVIDADE 18

    Desenvolva um sistema para gerenciar
    médias escolares.

    Solicite notas, calcule médias e
    informe a situação do aluno.
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
    int aprovados = 0;
    int reprovados = 0;
    string resposta;

    do
    {
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Nota 1: ");
        double n1 = LerDouble();

        Console.Write("Nota 2: ");
        double n2 = LerDouble();

        double media = (n1 + n2) / 2;

        if (media >= 7)
        {
            Console.WriteLine($"{nome} aprovado(a)");
            aprovados++;
        }
        else
        {
            Console.WriteLine($"{nome} reprovado(a)");
            reprovados++;
        }

        Console.Write("Cadastrar outro aluno? (SIM/NAO): ");
        resposta = Console.ReadLine().Trim().ToUpper();

    } while (resposta == "SIM");

    Console.WriteLine($"Aprovados: {aprovados} | Reprovados: {reprovados}");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 18");
    Console.WriteLine("Sistema para gerenciamento de médias escolares.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}

static double LerDouble()
{
    while (true)
    {
        try { return double.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número válido: "); }
    }
}
