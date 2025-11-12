<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>tabela</title>
</head>
<body>
    <!--Tabela simples-->
    <table border=1>
        <tbody>
            <tr>
                <!--
                Aqui mostra o cadastro do usuário:
                $_POST é uma variável superglobal que guarda os 
                dados através de um array associativo, onde cada
                campo é indetificado através do atributo "name",
                os nomes utilizados foram nome, idade e cpf.
                -->
                <td>
                Nome: <?php echo $_POST["nome"];?><br>
                Idade: <?php echo $_POST["idade"];?><br>
                CPF: <?php echo $_POST["cpf"];?>
                </td>
            </tr>
        </tbody>
    </table>

    <a href="index.html">voltar</a>
</body>
</html>