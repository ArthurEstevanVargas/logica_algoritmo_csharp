/*
    ATIVIDADE 04

    Peça um dia de um determinado mês/ano, retorne o dia da semana.

    Observação: Neste exercício será utilizado como base o calendário de
    maio de 2024, mas fique à vontade para escolher outro mês/ano.

    Observação: Para saber se um ano é bissexto existe uma regra básica: os anos bissextos são aqueles múltiplos de 4, ou seja, a cada quatro anos temos um ano bissexto. 
    Por outro lado, esses anos não são múltiplos de 100 (por exemplo,1800, 1900, 2100), exceto os múltiplos de 400 (por exemplo, 1600, 2000, 2400).

    Observação = f(diaalvo - diaancora).
*/

int diaalvo = 0;
int diaancora = 1;
int diadasemana = 0;

Console.WriteLine("Informe um data");
string data = Console.ReadLine();

string[] partes = data.Split("/");

int dia = int.Parse(partes[0]);
int mes = int.Parse(partes[1]);
int ano = int.Parse(partes[2]);

int[] diasdoano = {31,0,31,30,31,30,31,31,30,31,30,31};

if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
{
    diasdoano[1] = 29;
} else if (ano % 100 == 0)
{
    diasdoano[1] = 28;
}

for (int indice = 0; indice < (mes - 1); indice++)
{
    diaalvo += diasdoano[indice];
}
diaalvo += dia;
diadasemana = (diaalvo - diaancora) % 7;

string retorno = diadasemana switch
{
    0 => "Segunda-feira",
    1 => "Terça-feira",
    2 => "Quarta-feira",
    3 => "Quinta-feira",
    4 => "Sexta-feira",
    5 => "Sábado",
    6 => "Domingo",
    _ => "Ops, aconteceu algum erro"
};

Console.WriteLine(retorno);