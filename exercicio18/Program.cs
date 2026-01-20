/*
    ATIVIDADE 18

    Sistema para gerenciar médias escolares.

    Peça duas notas, calcule a média e informe a situação.
    Ao final, exiba a quantidade de alunos aprovados e reprovados.
*/

// Declaração de variáveis
string opcao;
int aprovados = 0;
int reprovados = 0;

// Estrutura de repetição
do
{
    Console.Write("Informe o nome do aluno: ");
    string nome = Console.ReadLine();

    Console.Write("Informe a primeira nota do aluno: ");
    double nota01 = double.Parse(Console.ReadLine());

    Console.Write("Informe a segunda nota do aluno: ");
    double nota02 = double.Parse(Console.ReadLine());

    double media = (nota01 + nota02) / 2;

    if (media >= 7)
    {
        Console.WriteLine($"O aluno {nome} está Aprovado(a).");
        aprovados++;
    }
    else
    {
        Console.WriteLine($"O aluno {nome} está Reprovado(a).");
        reprovados++;
    }

    Console.Write("Deseja cadastrar mais um aluno(a)? (SIM/NAO): ");
    opcao = Console.ReadLine().Trim().ToUpper();

}
while (opcao == "SIM");

// Saída final
Console.WriteLine($"A quantidade de alunos aprovados foi {aprovados} e de reprovados foi {reprovados}.");
