<?php

//Variáveis superglobais que guardam os valores do
//formulário 

//Esses dois tendo associação com o atributo "name"
$n1 = $_POST["num1"];
$n2 = $_POST["num2"];
//Esse tendo associação com o atributo "value"
$op = $_POST["operacao"];

//Funções com cada operação
function adicao($n1, $n2){
    return $n1+$n2;
}
function subtracao($n1, $n2){
    return $n1-$n2; 
}
function multiplicacao($n1, $n2){
    return $n1*$n2;
}
function divisao($n1, $n2){
    if ($n2 == 0) {
        echo "Não se divide por 0";
    } else {
        return $n1/$n2;
    }
}

//Seção de opções para cada operação
switch($op){
    case "+":
        echo adicao($n1, $n2);
        break;
    case "-":
        echo subtracao($n1, $n2);
        break;
    case "x":
        echo multiplicacao($n1, $n2);
        break;
    case "/":
        echo divisao($n1, $n2);
        break;
    default:
        echo "Não foi possível realizar o calculo";
}
?>