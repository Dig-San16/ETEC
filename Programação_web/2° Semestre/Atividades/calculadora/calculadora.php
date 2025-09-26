<?php
$num1 = $_POST["num1"];
$num2 = $_POST["num2"];
$operacao = $_POST["operacao"];

function adicao($num1, $num2){
    return $num1 + $num2;
}
function subtracao($num1, $num2){
    return $num1 - $num2;
}
function multiplicacao($num1, $num2){
    return $num1 * $num2;
}
function divisao($num1, $num2){
    if ($num1 == 0 || $num2 == 0){
        echo "não se divide por 0";
    } else{
        return $num1 / $num2;
    }
}

switch($operacao){
    case "adicao":
        echo adicao($num1, $num2);
        break;
    case "subtracao":
        echo subtracao($num1, $num2); 
        break;
    case "multiplicacao":
        echo multiplicacao($num1, $num2); 
        break;
    case "divisao":
        echo divisao($num1, $num2);  
        break;
    default:
        echo "selecione a operação";
        break;
}
?>