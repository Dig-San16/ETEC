<?php

$nome = "Pamela";
$idade = 20;
$idades = "20";
echo "Boa noite, " .$nome;
echo "<br>Minha idade é: " .$idade;
echo "<br>A idade dela é: " .$idades;

//estrutura de condição if, if else, else
if($idade >= 18){
    echo "<br>Maior<br>";
}
else{
   echo "Menor <br>";
}

//estrutura de repetição while
while($idade < 18){
    echo  "Você não tem idade para dirigir.<br>";
    echo "Idade atual: ".$idade;
    $idade = $idade +1;
}

//estrutura de repetição do while
do{
    echo  "Você não tem idade para dirigir.<br>";
    echo "Idade atual: ".$idade;
    $idade = $idade +1;
}while ($idade < 18);

//estrutura de repetição for
for($i=0; $i<10; $i++){
    echo "<br>Valor de i: ".$i;
}

//estrutura de repetição "Caso"
$idade1 = 18;
switch($idade1){
    case "16":
    echo "<br>Você pode votar<br><br>";
    break;
    case "18":
    echo "<br>Você pode dirigir<br><br>";
    break;
    default:
    if($idade1 > 18){
    echo "<br>Você já alcançou a maioridade";
    } else {
        echo "<br>Você pode estudar<br><br>";
    }
    break;
}

//vetores
/*$lista[] = 1;
$lista[] = 2;
$lista[] = 3;
$lista[] = 4;
echo "<pre>";
$lista1 = array([1, 2, 3, 4, 5, 6]);
var_dump($lista1);
*/

//vetores
$lista["nome"] = "Tio Patinhas";
$lista["e-mail"] = "tp@disney.com";
$lista[4] = 3;
$lista[] = 4;
$lista[2] = "2";
//vetores de vetores
$alunos["2B"][] = "Alex";
$alunos["2B"][] = "Adailton";
unset($alunos["2B"][1]);
echo "<br>Aluno: ".$alunos["2B"][0];
echo "<pre>";
var_dump($alunos);




