<?php 
include "funcoes.php";
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php

$retorno = soma($_POST["numero1"],$_POST["numero2"]);

msg($retorno);
?>

</body>
</html>




