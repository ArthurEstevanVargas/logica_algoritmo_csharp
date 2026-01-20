/*
    ATIVIDADE 23

    Peça cinco nomes e adicione cada um em uma posição do vetor.

    Depois exiba cada nome informado.
*/

string?[] nomes = new string[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write("Informe um nome:");
    nomes[i] = Console.ReadLine();
}

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}