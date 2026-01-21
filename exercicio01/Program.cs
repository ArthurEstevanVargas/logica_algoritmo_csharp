/*
    ATIVIDADE 01

    Solicite ao usuário dois números inteiros.

    - Caso os números sejam iguais, realize a soma entre eles.
    - Caso sejam diferentes, realize a multiplicação.

    Ao final, exiba o resultado da operação realizada.
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
    int numero02;

    Console.Write($"Informe o primeiro número: ");
    numero01 = LerInteiro();

    Console.Write($"Informe o segundo número: ");
    numero02 = LerInteiro();

    Console.WriteLine(numero01 == numero02 ? $"A soma dos números é {numero01 + numero02}." : $"A multiplicação dos números é {numero01 * numero02}.");
    
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 01");
    Console.WriteLine("Solicite dois números inteiros.");
    Console.WriteLine("Se forem iguais, realize a soma.");
    Console.WriteLine("Se forem diferentes, realize a multiplicação.");
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