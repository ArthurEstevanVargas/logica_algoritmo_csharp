/*
    ATIVIDADE 05

    Solicite ao usuário um ano.

    Verifique se o ano informado é bissexto,
    considerando as regras:

    - Múltiplos de 4
    - Não múltiplos de 100, exceto se forem múltiplos de 400
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
    Console.Write("Informe um ano: ");
    int ano = LerInteiro();
    
    Console.WriteLine((ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0)) ? $"O ano {ano} é bissexto" : $"O ano {ano} não é bissexto");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 05");
    Console.WriteLine("Solicite um ano.");
    Console.WriteLine("Verifique se o ano é bissexto ou não.");
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
