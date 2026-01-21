/*
    ATIVIDADE 14

    Solicite dois números inteiros.

    Exiba todos os valores existentes
    entre esses dois números.
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
    Console.Write("Informe o primeiro número: ");
    int n1 = LerInteiro();

    Console.Write("Informe o segundo número: ");
    int n2 = LerInteiro();

    if (n1 > n2)
    {
        int aux = n1;
        n1 = n2;
        n2 = aux;
    }

    do
    {
        Console.WriteLine(n1);
        n1++;
    } while (n1 <= n2);
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 14");
    Console.WriteLine("Solicite dois números inteiros.");
    Console.WriteLine("Exiba os valores existentes entre eles.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
