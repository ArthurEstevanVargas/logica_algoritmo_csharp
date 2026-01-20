/*
    ATIVIDADE 06

    Peça um número inteiro e retorne se é
    positivo, negativo ou neutro.

    Exemplos:
    -5  : Negativo
     34 : Positivo
     -3 : Negativo
      0 : Neutro
*/

// Entrada de dados
Console.WriteLine("Informe um número neutro, positivo ou negativo:");
int numero = int.Parse(Console.ReadLine());

// Processamento
string retorno = numero switch
{
    0 => "Neutro",
    < 0 => "Negativo",
    > 0 => "Positivo"
};

// Saída
Console.WriteLine($"O número {numero} é {retorno}");
