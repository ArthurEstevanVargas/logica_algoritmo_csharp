/*
    ATIVIDADE 04

    Peça um dia de um determinado mês/ano, retorne o dia da semana.

    Observação: Neste exercício será utilizado como base o calendário de
    maio de 2024, mas fique à vontade para escolher outro mês/ano.
*/

// Data que você quer calcular
int dia = 29;
int mes = 10;
int ano = 2024;

// ================================
// Dia base conhecido
// Exemplo: 01/01/2024 = Segunda
// 0 = Segunda, 1 = Terça, ..., 6 = Domingo
// ================================
int diaBaseSemana = 0;

int totalDias = 0;

// ================================
// Somar dias dos anos anteriores
// ================================
for (int a = 2024; a < ano; a++)
{
    bool bissexto =
        (a % 4 == 0 && a % 100 != 0) ||
        (a % 400 == 0);

    totalDias += bissexto ? 366 : 365;
}

// ================================
// Dias por mês
// ================================
int[] diasPorMes =
{
    31, // Janeiro
    28, // Fevereiro
    31, // Março
    30, // Abril
    31, // Maio
    30, // Junho
    31, // Julho
    31, // Agosto
    30, // Setembro
    31, // Outubro
    30, // Novembro
    31  // Dezembro
};

// ================================
// Ajustar fevereiro se bissexto
// ================================
bool anoBissexto =
    (ano % 4 == 0 && ano % 100 != 0) ||
    (ano % 400 == 0);

if (anoBissexto)
    diasPorMes[1] = 29;

// ================================
// Somar dias dos meses anteriores
// ================================
for (int i = 0; i < mes - 1; i++)
{
    totalDias += diasPorMes[i];
}

// ================================
// Somar os dias do mês atual
// ================================
totalDias += dia - 1;

// ================================
// Calcular deslocamento do dia da semana
// ================================
int resultado = (diaBaseSemana + totalDias) % 7;

// resultado → número de 0 a 6
// Você decide como mapear depois