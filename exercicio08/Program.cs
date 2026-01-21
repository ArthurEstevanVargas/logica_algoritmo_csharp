/*
    ATIVIDADE 08

    Solicite ao usuário três valores
    correspondentes aos lados de um triângulo.

    Determine o tipo do triângulo:
    - Equilátero
    - Isósceles
    - Escaleno
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
    int[] lados = new int[3];

    for (int i = 0; i < lados.Length; i++)
    {
        Console.Write("Informe um lado do triângulo: ");
        lados[i] = LerInteiro();
    }

    if (lados[0] == lados[1] && lados[0] == lados[2])
    {
        Console.WriteLine("Equilátero");
    }
    else if (lados[0] == lados[1] || lados[0] == lados[2] || lados[1] == lados[2])
    {
        Console.WriteLine("Isósceles");
    }
    else
    {
        Console.WriteLine("Escaleno");
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 08");
    Console.WriteLine("Solicite três lados de um triângulo.");
    Console.WriteLine("Informe o tipo do triângulo.");
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
