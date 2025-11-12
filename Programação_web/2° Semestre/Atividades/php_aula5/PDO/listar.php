<?php
require "conexao.php";

$alunos = $pdo->query("SELECT * FROM alunos ORDER BY id DESC")->fetchAll(PDO::FETCH_ASSOC);
//query() executa um comando SQL diretamente (sem necessidade de prepare, pois não há 
//entrada do usuário).

//fetchAll(PDO::FETCH_ASSOC) retorna todos os registros em formato de array associativo,
//onde o formato dos dados se assemelham com o JSON

?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Lista de Alunos</title>
</head>
<body>

    <!--Título-->
    <h2>Alunos Cadastrados</h2>

    <!--Seção de cadastro-->
    <table border="1">

        <!--Nome das colunas-->
        <tr>
            <th>ID</th>
            <th>Nome</th>
            <th>Email</th>
            <th>Idade</th>
            <th>Ações</th>
        </tr>

        <!--foreach Percorre todos os registros de $alunos-->
        <?php foreach ($alunos as $a): ?>
            <tr>

                <td><?= $a['id'] ?></td>
                
                <!--htmlspecialchars() evita falhas de segurança (XSS)-->
                <td><?= htmlspecialchars($a['nome']) ?></td>
                <td><?= htmlspecialchars($a['email']) ?></td>
                <td><?= $a['idade'] ?></td>
                <td>
                    <a href="editar.php?id=<?= $a['id'] ?>">Editar</a> 
                    <a href="deletar.php?id=<?= $a['id'] ?>">Excluir</a>
                </td>

            </tr>
        <?php endforeach; ?>

    </table>

    <!--Hyperlink para a página principal-->
    <br>
    <a href="index.html">Voltar ao cadastro</a>

    <style>
        table {
            max-width: 300px;
        }
    </style>
</body>
</html>


