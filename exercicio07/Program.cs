/*
    ATIVIDADE 07

    Peça três números inteiros e retorne qual deles é o menor.
*/

int[] numeros = new int[3];

for (int indice = 0; indice < numeros.Length; indice++)
{
    Console.WriteLine($"Informe um número:");
    numeros[indice] = int.Parse(Console.ReadLine());
}

int menornumero = numeros[0];

for (int indice = 0; indice < numeros.Length; indice++)
{
    if (numeros[indice] < menornumero)
    {
        menornumero = numeros[indice];
    }
}

Console.WriteLine($"O menor número é {menornumero}");