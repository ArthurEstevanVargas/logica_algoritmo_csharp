// Variável
string linguagem = "Java";

// Estrutura de escolha
switch(linguagem)
{
    case "HTML":
        Console.WriteLine("Linguagem de marcação");
    break;
    case "CSS":
        Console.WriteLine("Linguagem de estilos.");
    break;
    case "C#":
        Console.WriteLine("Linguagem de programação.");
    break;
    default:
        Console.WriteLine("Linguagem desconhecida");
    break;
}

// Variável
string linguagem = "HTML";

// Expressão switch
String retorno = linguagem switch
{
    "HTML" => "Linguagem de marcação",
    "CSS" => "Linguagem de estilos",
    "C#" => "Linguagem de programação",
    _ => "Linguagem desconhecida"
};