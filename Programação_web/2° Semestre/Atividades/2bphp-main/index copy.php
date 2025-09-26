<?php

$nome = "Tio Patinhas";
$idade = 20;
echo "<br>Idade:".$idade;
$idade = "Texto";
echo "<br>Boa noite, ".$nome;
echo "<br>Idade:".$idade;

$lista["nome"] = "Tio Patinhas";
$lista["Email"] = "tp@disney.com";
$lista[4] = 3;
$lista[]  = 4;
$lista[2] = "2";
$alunos["2B"][] = "Adailton";
$alunos["2B"][] = "Alex";
unset($alunos["2B"][1]);

echo "<br>Aluno:".$alunos["2B"][0];
echo "<pre>";
var_dump($alunos);

if($idade>18){
    echo "Maior";
} else { 
    echo "Menor";
}
$idade = 18;

do {
    echo " Voce nao tem idade para Dirigir:<br>";
    echo "Idade atual:".$idade;
    $idade = $idade +1;
 }while($idade<18);

 for($i=0; $i<11;$i++){
    echo "<br>valor de i:".$i;
 }

echo "<br>";
$idade = 20;
 switch ($idade) {
    case "16":
        echo "Voce pode votar";

   
        case "17":
        echo "Voce pode votar";
        echo "<br> Não pode dirigir";
        break;
    case "18":
        echo "voce pode dirigir";
        break;
    default:
        if($idade>18){
            echo "Voce ja alcançou a maioridade";
        } else {
          echo "Voce pode estudar...";
        }
        break;
 }