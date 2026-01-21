/*
    ATIVIDADE 03

    Solicite ao usuário duas notas.

    Calcule a média aritmética e informe a situação do aluno:

    - Média entre 7 e 10   : Aprovado(a)
    - Média entre 5 e 6.9  : Recuperação
    - Média entre 0 e 4.9  : Reprovado(a)
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
    int auxiliar;
    double media;

    for (int indice = 0; indice < 2; indice++)
    {
        Console.Write($"Informe a {indice+1}° nota: ");
        media += LerDouble();
        auxiliar ++;
    }

    media /= auxiliar;

    if (media >= 7 && media <= 10)
    {
        Console.WriteLine("Aprovado(a)");
    }
    else if (media >= 5 && media <= 6.9)
    {
        Console.WriteLine("Recuperação");
    }
    else if (media >= 0 && media <= 4.9)
    {
        Console.WriteLine("Reprovado(a)");
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 03");
    Console.WriteLine("Solicite duas notas.");
    Console.WriteLine("Calcule a média e informe a situação do aluno.");
}

static int LerDouble()
{
    while (true)
    {
        try
        {
            return double.Parse(Console.ReadLine());
        }
        catch
        {
            Console.Write("Entrada inválida. Digite um número inteiro: ");
        }
    }
}