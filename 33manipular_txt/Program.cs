// Variável contendo um texto
string texto = "Gerando um arquivo de texto.";

// Criar o arquivo de texto e adicionar o valor da variável texto
File.WriteAllText("arquivo.txt", texto);

// Ler o arquivo gerado
string lerTexto = File.ReadAllText("arquivo.txt");

// Exibir o valor extraído do arquivo de texto
Console.WriteLine(lerTexto);

// [PRINCIPAIS COMANDOS PARA MANIPULAR ARQUIVOS DE TEXTO]

// - File.WriteAllText(string path, string contents): Escreve o texto especificado em um arquivo, substituindo o conteúdo se o arquivo já existir, caso contrário, cria um novo arquivo.

// - File.AppendAllText(string path, string contents): Anexa texto ao final de um arquivo existente ou cria um novo arquivo se ele não existir.

// - File.ReadAllLines(string path): Lê todas as linhas de um arquivo de texto em uma matriz de strings.

// - File.ReadAllBytes(string path): Lê todos os bytes de um arquivo em uma matriz de bytes.

// - File.WriteAllText(string path, string contents, Encoding encoding): Escreve o texto especificado em um arquivo usando o codificador de caracteres especificado.

// - File.ReadAllLines(string path, Encoding encoding): Lê todas as linhas de um arquivo de texto usando o codificador de caracteres especificado em uma matriz de strings.

// - File.ReadAllBytes(string path): Lê todos os bytes de um arquivo em uma matriz de bytes.

// - File.WriteAllText(string path, string contents, Encoding encoding): Escreve o texto especificado em um arquivo usando o codificador de caracteres especificado.

// - File.ReadAllLines(string path, Encoding encoding): Lê todas as linhas de um arquivo de texto usando o codificador de caracteres especificado em uma matriz de strings.