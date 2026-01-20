/*
    ATIVIDADE 23

    Peça cinco nomes e armazene em um vetor.
    Depois exiba todos os nomes informados.
*/

// Declaração do vetor
string?[] nomes = new string[5];

// Entrada de dados
for (int i = 0; i < nomes.Length; i++)
{
    Console.Write("Informe um nome: ");
    nomes[i] = Console.ReadLine();
}

// Saída
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
