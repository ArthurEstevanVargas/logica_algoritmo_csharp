/*
    ATIVIDADE 10

    Peça um valor monetário e escolha o tipo de conversão:

    - Real para Dólar
    - Dólar para Real

    Retorne o valor convertido.
*/

// Declaração de variáveis
string[] conversoes = { "Real para Dólar", "Dólar para Real" };

// Entrada de dados
Console.WriteLine("Informe um valor monetário:");
double valormonetario = double.Parse(Console.ReadLine());

Console.WriteLine("Informe uma conversão:");
foreach (string conversao in conversoes)
{
    Console.WriteLine(conversao);
}

string conversaoselecionada = Console.ReadLine();

// Processamento
double retorno = conversaoselecionada switch
{
    "Real para Dólar" => valormonetario / 5.37,
    "Dólar para Real" => valormonetario * 5.37,
    _ => 0
};

// Saída
Console.WriteLine($"A conversão de {retorno} foi de {valormonetario}");
