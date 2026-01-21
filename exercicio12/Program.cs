/*
    ATIVIDADE 12

    Solicite nomes ao usuário.

    O programa deve continuar solicitando
    até que seja informado o termo \"sair\".

    Ao digitar \"sair\", o programa deve ser encerrado.
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
    string texto;
    do
    {
        Console.Write("Digite um nome (ou sair): ");
        texto = Console.ReadLine();
    } while (texto != "sair");
}

static void MostrarDescricao()
{
    Console.WriteLine("ATIVIDADE 12");
    Console.WriteLine("Solicite nomes ao usuário.");
    Console.WriteLine("O programa encerra ao digitar \"sair\".");
}

static int LerInteiro()
{
    while (true)
    {
        try { return int.Parse(Console.ReadLine()); }
        catch { Console.Write("Digite um número inteiro: "); }
    }
}
