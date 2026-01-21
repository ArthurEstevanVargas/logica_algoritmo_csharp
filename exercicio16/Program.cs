/*
    ATIVIDADE 16

    Gere aleatoriamente um número entre 1 e 10.

    Enquanto o usuário não acertar o valor,
    continue solicitando novos palpites.
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
    Random random = new Random();
    int numeroAleatorio = random.Next(1, 11);
    int numeroInformado;

    do
    {
        Console.Write("Informe um número entre 1 e 10: ");
        numeroInformado = LerInteiro();
    }
    while (numeroInformado != numeroAleatorio);

    Console.WriteLine("Parabéns! Você acertou o número.");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 16");
    Console.WriteLine("Gere um número aleatório entre 1 e 10.");
    Console.WriteLine("Solicite palpites até o usuário acertar.");
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
