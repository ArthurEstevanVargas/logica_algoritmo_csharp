/*
    ATIVIDADE 04

    Solicite ao usuário um dia, mês e ano.

    Com base no calendário de maio de 2024,
    determine o dia da semana correspondente.

    Considere as regras de ano bissexto e utilize
    o cálculo baseado na diferença entre o dia alvo
    e o dia âncora.
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
    int diaalvo;
    int diaancora;
    int diadasemana;

    Console.Write("Informe uma data (dd/mm/aaaa):");
    string data = Console.ReadLine();

    string[] partes = data.Split("/");

    int dia = int.Parse(partes[0]);
    int mes = int.Parse(partes[1]);
    int ano = int.Parse(partes[2]);

    int[] diasdoano = { 31, 0, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
    {
        diasdoano[1] = 29;
    }
    else
    {
        diasdoano[1] = 28;
    }

    for (int indice = 0; indice < (mes - 1); indice++)
    {
        diaalvo += diasdoano[indice];
    }

    diaalvo += dia;
    diadasemana = (diaalvo - diaancora) % 7;

    string retorno = diadasemana switch
    {
        0 => "Segunda-feira",
        1 => "Terça-feira",
        2 => "Quarta-feira",
        3 => "Quinta-feira",
        4 => "Sexta-feira",
        5 => "Sábado",
        6 => "Domingo",
        _ => "Ops, aconteceu algum erro"
    };
    
    Console.WriteLine(retorno);
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 04");
    Console.WriteLine("Solicite um dia, mês e ano.");
    Console.WriteLine("Retorne o dia da semana correspondente.");
    Console.WriteLine("Considere regras de ano bissexto.");
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