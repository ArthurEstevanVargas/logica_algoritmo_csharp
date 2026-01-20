/*
    ATIVIDADE 20

    Exiba cem asteriscos da seguinte maneira:

    * * * * * * * * * *
    * * * * * * * * * *
    * * * * * * * * * *
    * * * * * * * * * *
    * * * * * * * * * *
    * * * * * * * * * *
    * * * * * * * * * *
    * * * * * * * * * *
    * * * * * * * * * *
    * * * * * * * * * *
*/

for (int i = 1; i <= 100; i++)
{
    string retorno = i % 10 == 0 ? "*\n" : "* ";
    Console.Write(retorno);
}