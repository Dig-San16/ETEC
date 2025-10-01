<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Programação Orienteda a Objeto em PHP</title>
</head>
<body>
    <?php
    include_once 'Pessoa.class.php';
    // Criar objeto
    $pessoa01 = new Pessoa();
    // Atribuir valor ao atributo da class
    $pessoa01->nome='Alexandre';
    // Exibir nome
    echo $pessoa01->nome;
    // Erro ao exibir cpf, pois cpf é private
    // echo $pessoa01->cpf;
    $pessoa01->exibirMensagem();
    ?>
</body>
</html>