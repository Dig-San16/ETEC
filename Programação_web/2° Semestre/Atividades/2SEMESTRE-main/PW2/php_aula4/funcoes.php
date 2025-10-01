<?php

// ****com parâmetro e sem retorno****
function mensagem ($nome){
    echo "Boa noite," .$nome."! Não usar o celular";
}
    // No html colocar
    mensagem("Kaua");


// ****sem parâmetro e sem retorno****

function mensagem1(){
    echo "Boa noite! Não usar o celular";
}
    // No html colocar
    mensagem1("Kaua");
 
// ****com parâmetro e com retorno**** 
function mensagem2($nome){
    $msg = "Boa noite, " .$nome. "! Não use o celular.";
    return $msg;
} 
    // No html colocar
    $msg=mensagem2("Kaua");
    echo $msg;


// ****sem parâmetro e com retorno****
function mensagem3(){
    
    return "Boa noite! Não use o celular.";
} 
    // No html colocar
    echo mensagem3(); //e fora do php Tio Patinhas


// ****função chamado a outra****
function mensagem4(){
    
    echo "Boa noite! Não use o celular.<br>";
    function BoaNoite(){
    mensagem4();
    return "Boa noite!";
} 
    // No html colocar
    echo mensagem4(); // e fora do php Tio Patinhas
}
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php 
    
    ?>
</body>
</html>