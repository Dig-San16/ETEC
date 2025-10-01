<?php
include_once "header.php";
include_once "conexao.php";
$dados=$conn->query('select * from Usuario');
while($row=$dados->fetch(PDO::FETCH_OBJ)){
   echo $row->nome_user.'<br>';
}
include_once "footer.php";
?>