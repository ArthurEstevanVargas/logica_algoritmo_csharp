/*
    ATIVIDADE 09

    Peça uma hora referente ao horário de Brasília (0 a 23).
    Em seguida liste três cidades e peça para selecionar uma.
    Retorne o horário da cidade selecionada.

    Fusos horários:
    - Tóquio  : +12
    - Lisboa : +4
    - Paris  : +5
*/

// Declaração de variáveis
string[] cidades = { "Tóquio", "Lisboa", "Paris" };

// Entrada de dados
Console.WriteLine("Informe um horário no horário de Brasília:");
int horariobrasilia = int.Parse(Console.ReadLine());

Console.WriteLine("Selecione uma das cidades:");
foreach (string cidade in cidades)
{
    Console.WriteLine(cidade);
}

string cidadeselecionada = Console.ReadLine();

// Processamento
int retorno = cidadeselecionada switch
{
    "Tóquio" => horariobrasilia += 12,
    "Lisboa" => horariobrasilia += 4,
    "Paris" => horariobrasilia += 5,
    _ => 0
};

// Saída
if (retorno > 23)
{
    Console.WriteLine($"Na cidade de {cidadeselecionada} são {retorno - 24}");
}
else
{
    Console.WriteLine($"Na cidade de {cidadeselecionada} são {retorno}");
}
