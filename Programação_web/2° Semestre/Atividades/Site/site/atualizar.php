<?php
require "conexao.php";

$id = 1;
$novoEmail = "maria.silva@gmail.com";

$sql = $pdo->prepare("UPDATE alunos SET email = ? WHERE id = ?");
$sql->execute([$novoEmail, $id]);

echo "Registro atualizado com sucesso!";
?>
