/*
    ATIVIDADE 10

    Peça um valor monetário, em seguida escolha o tipo de conversão:

    Real para Dólar
    Dólar para Real

    Retorne o valor convertido
*/

// Vetor
string[] conversoes = { "Real para Dólar", "Dólar para Real" };

// Obter o valor monetario
Console.WriteLine("Informe um valor monetário:");
double valormonetario = double.Parse(Console.ReadLine());

// Obter a conversão
Console.WriteLine("Informe uma conversão:");
foreach (string conversao in conversoes)
{
    Console.WriteLine(conversao);
}
string conversaoselecionada = Console.ReadLine();

double retorno = conversaoselecionada switch
{
    "Real para Dólar" => (valormonetario / 5.37),
    "Dólar para Real" => (valormonetario * 5.37),
    _ => 0
};

Console.WriteLine($"A conversão de {retorno} foi de {valormonetario}");