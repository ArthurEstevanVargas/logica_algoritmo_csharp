/*
    ATIVIDADE 30

    Desenvolva um sistema de compras utilizando uma matriz.

    A matriz deve armazenar informações dos produtos,
    como nome, quantidade e valor.

    Permita que o usuário realize compras e,
    ao final, exiba o valor total da compra.
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
    // Declaração da matriz
    string[,] produtos =
    {
        { "1", "Notebook Samsung", "4500" },
        { "2", "Teclado Microsoft", "280" },
        { "3", "Mouse HP", "90" },
        { "4", "MacBook Air", "5900" },
        { "5", "Impressora Epson", "540" },
        { "6", "iPad", "8700" },
        { "7", "Notebook Accer", "6200" },
        { "8", "Teclado Logitech", "190" },
        { "9", "MacBook Pro", "12500" },
        { "10", "Tablet Samsung", "2500" }
    };

    int opcaoProduto;
    double soma = 0;

    do
    {
        Console.WriteLine("\n=== PRODUTOS ===");

        for (int i = 0; i < produtos.GetLength(0); i++)
        {
            Console.WriteLine($"{produtos[i, 0]} - {produtos[i, 1]} | R$ {produtos[i, 2]}");
        }

        Console.Write("Informe o código do produto (0 para sair): ");
        opcaoProduto = LerInteiro();

        if (opcaoProduto > 0 && opcaoProduto <= produtos.GetLength(0))
        {
            soma += double.Parse(produtos[opcaoProduto - 1, 2]);
            Console.WriteLine("Produto adicionado ao carrinho.");
        }
        else if (opcaoProduto != 0)
        {
            Console.WriteLine("Código inválido.");
        }

    } while (opcaoProduto != 0);

    Console.WriteLine($"\nTotal da compra: R$ {soma}");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 30");
    Console.WriteLine("Sistema de compras utilizando matriz.");
    Console.WriteLine("Ao final, exiba o valor total da compra.");
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
            Console.Write("Digite um número inteiro válido: ");
        }
    }
}