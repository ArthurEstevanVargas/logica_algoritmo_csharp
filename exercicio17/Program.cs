/*
    ATIVIDADE 17

    Crie um sistema de votação

    Haverá quatro opções para o eleitor escolher, sendo três cadidatos e uma opção
    para finalizar a votação, exemplo:
    1) Ana
    2) Robson
    3) Evandro
    4) Sair

    Quando finalizar a votação, exiba a quantidade de votos de cada candidato.    
*/

int opcao;

string[,] candidatos = {
    {"1", "Ana"},
    {"2", "Robson"},
    {"3", "Evandro"},
    {"4", "Sair"}
};

int[] votos = new int[3];

do
{
    for (int i = 0; i < candidatos.GetLength(0); i++)
    {
        Console.WriteLine($"{candidatos[i,0]} - {candidatos[i,1]}");
    }

    Console.Write("Informe uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            votos[0]++;
            break;
        case 2:
            votos[1]++;
            break;
        case 3:
            votos[2]++;
            break;
        case 4:
            Console.WriteLine("Votação encerrada.");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

} while (opcao != 4);

Console.WriteLine("\nResultado da votação:");
for (int i = 0; i < votos.Length; i++)
{
    Console.WriteLine($"{candidatos[i,1]}: {votos[i]} votos");
}
