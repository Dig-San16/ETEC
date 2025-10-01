<?php
include_once "header.php";
include_once "conexao.php";
$dados=$conn->query('select * from Usuario');
foreach($dados->fetchAll(PDO::FETCH_OBJ) as $row){
   echo '<p>'.$row->nome_user.'</p>';
}
include_once "footer.php";
?>