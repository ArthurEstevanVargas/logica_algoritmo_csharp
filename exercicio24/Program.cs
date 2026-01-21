/*
    ATIVIDADE 24

    Solicite ao usuário cinco números inteiros.

    Calcule a média dos valores informados
    e exiba quais números são maiores ou
    iguais à média.
*/

Menu();

static void Menu()
{
    int opcao;
    do
    {
        Console.WriteLine("1 - Descrição");
        Console.WriteLine("2 - Executar exercício");
        Console.WriteLine("0 - Sair");

        opcao = LerInteiro();

        switch (opcao)
        {
            case 1: MostrarDescricao(); break;
            case 2: Executar(); break;
        }
    } while (opcao != 0);
}

static void Executar()
{
    int[] numeros = new int[5];
    double media = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write("Informe um número: ");
        numeros[i] = LerInteiro();
        media += numeros[i];
    }

    media /= numeros.Length;

    Console.WriteLine($"Média: {media}");

    foreach (int numero in numeros)
    {
        if (numero >= media)
        {
            Console.WriteLine($"{numero} é maior ou igual à média");
        }
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 24");
    Console.WriteLine("Solicite cinco números inteiros.");
    Console.WriteLine("Exiba a média e os valores maiores ou iguais a ela.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro válido: "); }
    }
}
