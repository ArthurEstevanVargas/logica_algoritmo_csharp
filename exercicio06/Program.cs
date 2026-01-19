/*
    ATIVIDADE 06

    Peça um número inteiro, retorne se é um numero positivo, neutro ou negativo.

    Exemplo:
    -5: Negativo
    34: Positivo
    -3: Negativo
     0: Neutro
*/

// Obter um número
Console.WriteLine("Informe um número neutro, positivo ou negativo");
int numero = int.Parse(Console.ReadLine());

// Expressão switch
string retorno = numero switch
{
    0 => "Neutro",
    < 0 => "Negativo",
    > 0 => "Positivo",
};

Console.WriteLine($"O número {numero} é {retorno}");