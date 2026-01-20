/*
    ATIVIDADE 18

    Desenvolva um sistema para gerenciar médias escolares.

    Em uma estrutura de repetição peça duas notas.

    Após obter as notas, retorne a média e a situação (>=7 aprovado e <7 reprovado).

    Depois de exibir a média e a situação, pergunte se deseja cadastrar mais algum aluno.

    Quando sair do laço de repetição, exiba a quantidade de alunos aprovados e reprovados.
*/

string opcao;
int aprovados = 0;
int reprovados = 0;

do
{
    Console.Write("Informe o nome do aluno:");
    string nome = Console.ReadLine();

    Console.Write("Informe a primeira nota do aluno:");
    double nota01 = double.Parse(Console.ReadLine());

    Console.Write("Informe a segunda nota do aluno:");
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
} while (opcao == "SIM");

Console.WriteLine($"A quantidade de alunos aprovados foi {aprovados} e de reprovados foi {reprovados}.");