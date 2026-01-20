/*
    ATIVIDADE 22

    Crie um vetor com 5 nomes.
    Peça um nome e retorne se ele existe no vetor.
*/

// Declaração de variáveis
string[] nomes = { "Arthur", "Pedro", "João", "Maria", "Bruno" };
string? nomeinformado;

// Entrada de dados
Console.Write("Informe um nome: ");
nomeinformado = Console.ReadLine();

// Processamento
foreach (string nome in nomes)
{
    if (nome == nomeinformado)
    {
        Console.WriteLine("O nome está na lista, parabéns!");
        return;
    }
}

// Saída
Console.WriteLine("O nome não está na lista, sinto muito!");
