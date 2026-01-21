/*
    ATIVIDADE 09

    Solicite ao usuário uma hora referente
    ao horário de Brasília.

    Escolha uma cidade e informe
    o horário correspondente, considerando
    o fuso horário.
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
    Console.Write("Informe o horário de Brasília (0 a 23): ");
    int hora = LerInteiro();

    Console.WriteLine("Selecione uma cidade:");
    Console.WriteLine("Tóquio");
    Console.WriteLine("Lisboa");
    Console.WriteLine("Paris");
    string cidade = Console.ReadLine();
    
    int resultado = cidade switch
    {
        "Tóquio" => hora + 12,
        "Lisboa" => hora + 4,
        "Paris" => hora + 5,
        _ => hora
    };

    if (resultado >= 24)
    {
        resultado -= 24;
    }

    Console.WriteLine($"Na cidade de {cidade} são {resultado} horas");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 09");
    Console.WriteLine("Solicite uma hora no horário de Brasília.");
    Console.WriteLine("Converta para o horário de outra cidade.");
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
