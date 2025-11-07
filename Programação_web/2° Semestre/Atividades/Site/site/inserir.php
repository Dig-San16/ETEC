<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    require "conexao.php";

    $nome = "Maria";
    $email = "maria@gmail.com";
    $idade = 16;

    $sql = $pdo->prepare("INSERT INTO alunos (nome, email, idade) VALUES (?, ?, ?)");
    $sql->execute([$nome, $email, $idade]);

    echo "Registro inserido com sucesso!";
    ?>
    <br>
    <a href="index.php">Voltar ao cadastro</a>
</body>
</html>
    
