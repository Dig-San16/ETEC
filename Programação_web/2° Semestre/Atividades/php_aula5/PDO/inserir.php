<?php
require "conexao.php";

//verifica se a página foi acessada via formulário POST.
if ($_SERVER["REQUEST_METHOD"] === "POST") {

    //Essas variáveis recebem os valores enviados pelo formulário HTML. 
    //nome, email e idade devem corresponder ao atributo "name" dos campos do <form>.
    $nome = $_POST["nome"];
    $email = $_POST["email"];
    $idade = $_POST["idade"];

    //Durante a inserção dos dados, a coluna email possui só pode
    //ter um email, não podendo repetir o mesmo email, ent usamos try-catch
    try {

        $sql = $pdo->prepare("INSERT INTO alunos (nome, email, idade) VALUES (?, ?, ?)");
        $sql->execute([$nome, $email, $idade]);

        echo "Registro inserido com sucesso!";
        echo "<br><a href='index.html'>Voltar</a>";

    //Em sql, o erro que impede colunas com o mesmo valor é o de número "23000"
    } catch (PDOException $e) {
        if ($e->getCode() == 23000) {
            echo "<h3>Erro: já existe um aluno cadastrado com esse e-mail!</h3>";
            echo "<a href='index.html'>Voltar</a>";
        } else {
            echo "Erro no cadastro: " . $e->getMessage();
        }
    }
}
?>

