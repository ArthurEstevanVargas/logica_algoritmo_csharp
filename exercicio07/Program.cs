/*
    ATIVIDADE 07

    Solicite ao usuário três números inteiros.

    Compare os valores e informe
    qual deles é o menor.
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
    int[] numeros = new int[3];

    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write("Informe um número: ");
        numeros[i] = LerInteiro();
    }

    int menor = numeros[0];

    for (int i = 1; i < numeros.Length; i++)
    {
        if (numeros[i] < menor)
        {
            menor = numeros[i];
        }
    }

    Console.WriteLine($"O menor número é {menor}.");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 07");
    Console.WriteLine("Solicite três números inteiros.");
    Console.WriteLine("Informe qual deles é o menor.");
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
