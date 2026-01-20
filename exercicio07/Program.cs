/*
    ATIVIDADE 07

    Peça três números inteiros e retorne
    qual deles é o menor.
*/

// Declaração do vetor
int[] numeros = new int[3];

// Entrada de dados
for (int indice = 0; indice < numeros.Length; indice++)
{
    Console.WriteLine("Informe um número:");
    numeros[indice] = int.Parse(Console.ReadLine());
}

// Processamento
int menornumero = numeros[0];

for (int indice = 0; indice < numeros.Length; indice++)
{
    if (numeros[indice] < menornumero)
    {
        menornumero = numeros[indice];
    }
}

// Saída
Console.WriteLine($"O menor número é {menornumero}");
