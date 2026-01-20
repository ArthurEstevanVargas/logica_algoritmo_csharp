/*
    ATIVIDADE 14

    Peça dois números, em seguida exiba os valores entre os números informados.

    Exemplo se informado 2 e 5, o retorno será 2 3 4 5.
*/

int auxiliar;

Console.WriteLine("Informe o primeiro número:");
int numero01 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número:");
int numero02 = int.Parse(Console.ReadLine());

if (numero01 > numero02)
{
    auxiliar = numero02;
    numero02 = numero01;
    numero01 = auxiliar;
}

do
{
    Console.WriteLine(numero01);
    numero01++;
} while (numero01 <= numero02);