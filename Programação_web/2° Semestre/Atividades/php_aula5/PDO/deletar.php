<?php
require "conexao.php";

//O PHP verifica se o id foi passado na URL
if (isset($_GET["id"])) {
    $id = $_GET["id"];
    $sql = $pdo->prepare("DELETE FROM alunos WHERE id = ?");
    $sql->execute([$id]);
}

echo "Registro removido com sucesso!";
echo "<br><a href='listar.php'>Voltar</a>";

?>
