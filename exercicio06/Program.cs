/*
    ATIVIDADE 06

    Solicite ao usuário um número inteiro.

    Verifique se o número é:
    - Positivo
    - Negativo
    - Neutro (zero)

    Exiba o resultado.
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
    Console.Write("Informe um número: ");
    int numero = LerInteiro();

    string retorno = numero switch
    {
        0 => "Neutro",
        < 0 => "Negativo",
        > 0 => "Positivo"
    };

    Console.WriteLine($"O número {numero} é {retorno}.");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 06");
    Console.WriteLine("Solicite um número inteiro.");
    Console.WriteLine("Informe se é positivo, negativo ou neutro.");
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
