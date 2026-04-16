<?php
require "conexao.php";

$id = $_GET["id"];
$sql = $pdo->prepare("SELECT * FROM alunos WHERE id = ?");
$sql->execute([$id]);
$aluno = $sql->fetch(PDO::FETCH_ASSOC);

if (!$aluno) {
    echo "Aluno não encontrado!";
}

if ($_SERVER["REQUEST_METHOD"] === "POST") {
    $nome = $_POST["nome"];
    $email = $_POST["email"];
    $idade = $_POST["idade"];

    $update = $pdo->prepare("UPDATE alunos SET nome = ?, email = ?, idade = ? WHERE id = ?");
    $update->execute([$nome, $email, $idade, $id]);

    echo "Registro alterado com sucesso!";
    echo "<br><a href='listar.php'>Voltar</a>";
    exit;
}
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Editar Aluno</title>
</head>
<body>
    <h2>Editar Aluno</h2>
    <form method="POST">
        <label>Nome:</label><br>
        <input type="text" name="nome" value="<?= htmlspecialchars($aluno['nome']) ?>" required><br><br>

        <label>Email:</label><br>
        <input type="email" name="email" value="<?= htmlspecialchars($aluno['email']) ?>" required><br><br>

        <label>Idade:</label><br>
        <input type="number" name="idade" value="<?= $aluno['idade'] ?>" required><br><br>

        <button type="submit">Salvar Alterações</button>
    </form>

    <br>
    <a href="listar.php">Voltar</a>
</body>
</html>

