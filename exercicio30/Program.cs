/*
    ATIVIDADE 30

    Desenvolva um sistema para efetuar compras.

    Haverá uma matriz 10x3 contendo: código, nome do produto e valor.

    Em uma estrutura de repetição, peça o código do produto que deseja adquirir.

    Enquanto não informado o código zero, peça para selecionar
    um produto.

    Quando informado o código zero, exiba o total da compra.
*/

string[,] produtos =
{
    {"1", "Notebook Samsung", "4500"},
    {"2", "Teclado Microsoft", "280"},
    {"3", "Mouse HP", "90"},
    {"4", "MacBook Air", "5900"},
    {"5", "Impressora Epson", "540"},
    {"6", "iPad", "8700"},
    {"7", "Notebook Accer", "6200"},
    {"8", "Teclado Logitech", "190"},
    {"9", "MacBook Pro", "12500"},
    {"10", "Tablet Samsung", "2500"}
};

int opcao;
double soma = 0;

do
{
    for (int linhas = 0; linhas < produtos.GetLength(0); linhas++)
    {
        Console.WriteLine($"{produtos[linhas,0]} - {produtos[linhas,1]} R$ {produtos[linhas,2]}");
    }
    Console.WriteLine("Selecione o código do produto para adicionar ao carrinho. (0 - sair)");
    opcao = int.Parse(Console.ReadLine()) - 1;
    if (opcao != -1)
    {
         soma += double.Parse(produtos[opcao,2]);
    }
} while (opcao != -1);

Console.WriteLine(soma);