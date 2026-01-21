/*
    ATIVIDADE 11

    Solicite ao usuário um número inteiro.

    Gere e exiba a tabuada desse número,
    do 1 ao 10.
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
    Console.Write("Informe um número: ");
    int numero = LerInteiro();

    int i = 0;
    while (i <= 10)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
        i++;
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 11");
    Console.WriteLine("Solicite um número inteiro.");
    Console.WriteLine("Exiba a tabuada desse número de 1 a 10.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
