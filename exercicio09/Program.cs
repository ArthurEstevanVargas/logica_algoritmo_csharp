/*
    ATIVIDADE 09

    Peça uma hora referente ao horário de Brasília (0 até 23).
    Em seguida liste três cidades e peça para selecionar uma.
    Tendo essas duas informações, retorne o horário da cidade selecionada.

    Algumas cidades e seus respectivos fusos horários:
    Tóquio: +12
    Lisboa: +4
    Paris: +5
*/

string[] cidades = { "Tóquio", "Lisboa", "Paris" };

Console.WriteLine("Informe um horário no horário de Brasília:");
int horariobrasilia = int.Parse(Console.ReadLine());

Console.WriteLine("Selecione uma das cidades:");
foreach (string cidade in cidades)
{
    Console.WriteLine(cidade);
}
string cidadeselecionada = Console.ReadLine();

int retorno = cidadeselecionada switch
{
    "Tóquio" => horariobrasilia += 12,
    "Lisboa" => horariobrasilia += 4,
    "Paris" => horariobrasilia += 5,
    _ => 0
};

if (retorno > 23)
{
    Console.WriteLine($"Na cidade de {cidadeselecionada} são {retorno - 24}");
}
else
{
    Console.WriteLine($"Na cidade de {cidadeselecionada} são {retorno}");
}