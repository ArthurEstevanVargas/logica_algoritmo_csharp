/*
    ATIVIDADE 04

    Peça um dia de um determinado mês/ano e retorne o dia da semana.

    Observações:
    - Base: calendário de maio de 2024
    - Regra de ano bissexto:
        * Múltiplos de 4
        * Não múltiplos de 100, exceto múltiplos de 400
    - Fórmula utilizada: f(diaAlvo - diaAncora)
*/

// Declaração de variáveis
int diaalvo = 0;
int diaancora = 1;
int diadasemana = 0;

// Entrada de dados
Console.WriteLine("Informe uma data (dd/mm/aaaa):");
string data = Console.ReadLine();

// Processamento da data
string[] partes = data.Split("/");

int dia = int.Parse(partes[0]);
int mes = int.Parse(partes[1]);
int ano = int.Parse(partes[2]);

int[] diasdoano = { 31, 0, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

// Verificação de ano bissexto
if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
{
    diasdoano[1] = 29;
}
else
{
    diasdoano[1] = 28;
}

// Cálculo do dia alvo
for (int indice = 0; indice < (mes - 1); indice++)
{
    diaalvo += diasdoano[indice];
}

diaalvo += dia;
diadasemana = (diaalvo - diaancora) % 7;

// Retorno do dia da semana
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

// Saída
Console.WriteLine(retorno);
