/*
    ATIVIDADE 17

    Crie um sistema de votação

    Haverá quatro opções para o eleitor escolher, sendo três cadidatos e uma opção
    para finalizar a votação, exemplo:
    1) Ana
    2) Robson
    3) Evandro
    4) Sair

    Quando finalizar a votação, exiba a quantidade de votos de cada candidato.    
*/

int opcao;
string[,] candidatos = {{"1","Ana"}, {"2","Robson"}, {"3","Evandro"}, {"4", "Sair"}};

do
{
    foreach (string candidato in candidatos)
    {
        Console.Write(candidato + " ");
    }
    opcao = int.Parse(Console.ReadLine());
    string retorno = opcao switch
    {
        
    };
} while (opcao != 4);