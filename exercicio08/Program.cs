/*
    ATIVIDADE 08

    Peça três lados de um triângulo e retorne o seu tipo:

    - Equilátero: todos os lados congruentes
    - Isósceles : dois lados congruentes
    - Escaleno  : todos os lados com medidas distintas
*/

// Declaração do vetor
int[] medidas = new int[3];

// Entrada de dados
for (int indice = 0; indice < medidas.Length; indice++)
{
    Console.WriteLine("Informe os lados do triângulo:");
    medidas[indice] = int.Parse(Console.ReadLine());
}

// Processamento e saída
if (medidas[0] == medidas[1] && medidas[0] == medidas[2])
{
    Console.WriteLine("Equilátero: todos os lados congruentes.");
}
else if (medidas[0] == medidas[1] || medidas[0] == medidas[2] || medidas[1] == medidas[2])
{
    Console.WriteLine("Isósceles: dois lados congruentes.");
}
else
{
    Console.WriteLine("Escaleno: todos os lados com medidas distintas.");
}
