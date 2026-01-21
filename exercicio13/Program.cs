/*
    ATIVIDADE 13

    Solicite diversos números inteiros ao usuário.

    O programa deve continuar solicitando valores
    até que seja informado o número zero.

    Ao final, exiba a soma de todos os números informados.
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
            case 0: break;
        }
    } while (opcao != 0);
}

static void Executar()
{
    int soma = 0;
    int numero;

    do
    {
        Console.Write("Informe um número (0 para sair): ");
        numero = LerInteiro();
        soma += numero;
    } while (numero != 0);

    Console.WriteLine($"Soma total: {soma}");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 13");
    Console.WriteLine("Solicite números até que seja informado zero.");
    Console.WriteLine("Exiba a soma dos valores digitados.");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
