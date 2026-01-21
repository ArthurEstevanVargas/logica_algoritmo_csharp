/*
    ATIVIDADE 02

    Solicite ao usuário um número inteiro.

    Verifique se o número informado é par ou ímpar,
    utilizando o operador módulo (%).

    Exiba o resultado na tela.
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
    int numero01;

    Console.Write("Informe o número: ");
    numero01 = LerInteiro();
    
    Console.WriteLine(numero01 % 2 == 0 ? $"O número {numero01} é par" : $"O número {numero01} é ímpar");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 02");
    Console.WriteLine("Solicite um número inteiro.");
    Console.WriteLine("Verifique se o número é par ou ímpar usando o operador %.");
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