/*
    ATIVIDADE 22

    Crie um vetor contendo 5 nomes.

    Será pedido um nome aleatório, retorne se o nome existe no vetor ou não.
*/

string[] nomes = {"Arthur", "Pedro", "João", "Maria", "Bruno"};

string ?nomeinformado;

Console.Write("Informe um nome:");
nomeinformado = Console.ReadLine();

foreach (string nome in nomes)
{
    if (nome == nomeinformado)
    {
        Console.WriteLine("O nome está na lista, parabéns!");
        return;
    } 
}
Console.WriteLine("O nome não está na lista, sinto muito!");