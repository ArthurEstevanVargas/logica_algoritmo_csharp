try
{
    Console.Write($"Informe um número: ");
    int numero = int.Parse(Console.ReadLine());
} catch(Exception e)
{
    Console.WriteLine($"Houve uma falha: {e.Message}");
} finally
{
    Console.WriteLine($"Sistema finalizado");
}