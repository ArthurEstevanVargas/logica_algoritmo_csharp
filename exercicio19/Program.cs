/*
    ATIVIDADE 19

    Exiba 5 valores aleatórios entre 1 e 30.
    Além do número, informe se é par ou ímpar.
*/

for (int i = 0; i < 5; i++)
{
    Random random = new Random();
    int numeroaleatorio = random.Next(1, 31);

    string tipo = numeroaleatorio % 2 == 0 ? "Par" : "Ímpar";

    Console.WriteLine($"{numeroaleatorio} - {tipo}");
}
