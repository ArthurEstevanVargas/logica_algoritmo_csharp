/*
    ATIVIDADE 15

    Gere automaticamente um número aleatório
    entre 1 e 10.

    Solicite palpites do usuário até que
    ele acerte o número gerado.
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
    Random random = new Random();
    int sorteado = random.Next(1, 11);
    int numero;

    do
    {
        Console.Write("Informe um número entre 1 e 10: ");
        numero = LerInteiro();
    } while (numero != sorteado);

    Console.WriteLine("Você acertou!");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 15");
    Console.WriteLine("Gere um número aleatório entre 1 e 10.");
    Console.WriteLine("Solicite valores até que o usuário acerte.");
}


static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
