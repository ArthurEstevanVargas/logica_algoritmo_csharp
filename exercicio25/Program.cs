/*
    ATIVIDADE 25

    Solicite ao usuário cinco números inteiros.

    Verifique em quais posições o número 5 aparece.

    Caso o número não seja encontrado,
    informe ao usuário.
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
    bool encontrou = false;

    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write("Informe um número: ");
        numeros[i] = LerInteiro();
    }

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] == 5)
        {
            Console.WriteLine($"O número 5 está na posição {i + 1}");
            encontrou = true;
        }
    }

    if (!encontrou)
    {
        Console.WriteLine("O número 5 não foi encontrado.");
    }
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 25");
    Console.WriteLine("Solicite cinco números inteiros.");
    Console.WriteLine("Informe as posições onde o número 5 aparece.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro válido: "); }
    }
}
