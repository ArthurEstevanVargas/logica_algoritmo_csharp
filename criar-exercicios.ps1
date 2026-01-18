for ($i = 1; $i -le 30; $i++) {
    $numero = $i.ToString("D2")
    $nomeProjeto = "exercicio$numero"
    dotnet new console -n $nomeProjeto
}