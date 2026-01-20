/*
    ATIVIDADE 20

    Exiba 100 asteriscos organizados em 10 linhas e 10 colunas.
*/

for (int i = 1; i <= 100; i++)
{
    string retorno = i % 10 == 0 ? "*\n" : "* ";
    Console.Write(retorno);
}
