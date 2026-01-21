/*
    ATIVIDADE 10

    Solicite ao usuário um valor monetário.

    Apresente opções de conversão
    (ex: dólar, euro, etc.) e realize
    a conversão escolhida.
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

        Console.Write("Escolha uma opção: ");
        opcao = LerInteiro();

        switch (opcao)
        {
            case 1:
                MostrarDescricao();
                break;
            case 2:
                Executar();
                break;
            case 0:
                Console.WriteLine("Encerrando o programa...");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    } while (opcao != 0);
}

static void Executar()
{
    Console.Write("Informe um valor monetário: ");
    double valor = LerDouble();

    Console.WriteLine("Escolha a conversão:");
    Console.WriteLine("1 - Real para Dólar");
    Console.WriteLine("2 - Dólar para Real");

    int opcao = LerInteiro();

    double resultado = opcao switch
    {
        1 => valor / 5.37,
        2 => valor * 5.37,
        _ => 0
    };

    Console.WriteLine($"Valor convertido: {resultado:F2}");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 10");
    Console.WriteLine("Solicite um valor monetário.");
    Console.WriteLine("Escolha o tipo de conversão e exiba o resultado.");
}

static int LerInteiro()
{
    while (true)
    {
        try
        {
            return int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.Write("Entrada inválida. Digite um número inteiro: ");
        }
    }
}

static double LerDouble()
{
    while (true)
    {
        try
        {
            return double.Parse(Console.ReadLine());
        }
        catch
        {
            Console.Write("Entrada inválida. Digite um número válido: ");
        }
    }
}
