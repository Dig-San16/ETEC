<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Lista de alunos cadastrados</h1>
    <table border=1>
        <tbody>
            <?php
            require "conexao.php";

            $sql = $pdo->query("SELECT * FROM alunos");

            foreach ($sql->fetchAll(PDO::FETCH_ASSOC) as $aluno) {
                echo "ID: " . $aluno["id"] . " | ";
                echo "Nome: " . $aluno["nome"] . " | ";
                echo "Email: " . $aluno["email"] . " | ";
                echo "Idade: " . $aluno["idade"] . "<br>";
            }
            ?>
        </tbody>
    </table>
    <a href="index.php">Voltar ao cadastro</a>

</body>
</html>

