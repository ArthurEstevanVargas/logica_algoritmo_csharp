/*
    ATIVIDADE 07

    Peça três números inteiros e retorne qual deles é o menor.
*/

// Vetor
int[] numeros = new int[3];

// Laço para
for (int indice = 0; indice < numeros.Length; indice++)
{
    Console.WriteLine($"Informe um número:");
    numeros[indice] = int.Parse(Console.ReadLine());
}

// Variável
int menornumero = numeros[0];

// Laço para
for (int indice = 0; indice < numeros.Length; indice++)
{
    if (numeros[indice] < menornumero)
    {
        menornumero = numeros[indice];
    }
}

Console.WriteLine($"O menor número é {menornumero}");