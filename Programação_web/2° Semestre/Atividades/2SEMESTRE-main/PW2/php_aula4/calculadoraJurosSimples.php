<!DOCTYPE html>
<html lang="pt-br">
<head>

    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Juros Simples</title>
</head>
<body>

<form action="resultadoJurosSimples.php" method="post">

<label for="Digite o capital">Capital:</label>
<input type="number" name="capital" placeholder="Digite o capital" step="0.01" required><br>
<label for="Digite o tempo do investimento">Tempo (em meses):</label>
<input type="number" name="tempo" placeholder="Digite o tempo do investimento" step="0.01" required><br>
<label for="Digite a taxa de juros">Taxa de Juros (%):</label>
<input type="number" name="taxa" placeholder="Digite a taxa de juros" step="0.01" required><br>
<label for="Digite o montante">Montante:</label>
<input type="number" name="montante" placeholder="Digite o montante" step="0.01" required><br>
<input type="submit" value="Calcular">
<input type="reset" value="limpar">
</form>

<body>

</body>
</html>