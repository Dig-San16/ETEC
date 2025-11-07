<?php
require "conexao.php";

$id = 1;

$sql = $pdo->prepare("DELETE FROM alunos WHERE id = ?");
$sql->execute([$id]);

echo "Registro removido com sucesso!";
?>
