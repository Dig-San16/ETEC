<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário PHP</title>
</head>
<body>
<form action="salvar_cadastro.php" method="get">
    <label for="">Nome:</label><br>
    <input type="text" name="nome"><br>
    <label for="">E-mail:</label><br>
    <input type="text" name="email"><br>
    <label for="">Telefone:</label><br>
    <input type="text" name="telefone"><br>
    <input type="submit" value="Enviar">
    <input type="reset" value="Limpar"><br>
    <button type="submit">Enviar</button>
    <button type="reset">Limpar</button>
</form>
</body>
</html>