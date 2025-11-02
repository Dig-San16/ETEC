<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calculadora</title>
</head>
<body>
    <form action="resultado.php" method="post">
        <Label for="Digite o primeiro número">Numero 1:</Label>
        <input type="number" name="n1"> 
        <label for="Digite o segundo número">Numero 2:</label>
        <input type="number" name="n2">
        <select value="operacao" name="operacao">
        <option value="soma">+</option>
        <option value="subtrair">-</option>
        <option value="multiplicar">x</option>
        <option value="dividir">/</option>
        <input type="submit" value="calcular">
        <input type="reset" value="limpar">
    </form>
</body>
</html>