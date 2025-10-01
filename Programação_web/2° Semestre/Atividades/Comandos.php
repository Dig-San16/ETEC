<?php

$nome = "Tio Patinhas";
$idade = "Texto";
echo "<br>Idade: ".$idade;
$idade = 20;
echo "<br>Nome: ".$nome;
echo "<br>Boa noite, meu nome é ". $nome . " e minha idade é ". $idade;

$lista["nome"] = "Tio Patinhas";
$lista["Email"] = "tp@disney.com";
$lista[4] = 3;
$lista[]  = 4;
$lista[2] = "2";
$alunos["2B"][] = "Adailton";
$alunos["2B"][] = "Alex";

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
 } while($idade<18);

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

$frutas = ["Maçã", "Banana", "Laranja"];
echo "<br>";
echo $frutas[0]; // Maçã
echo "<br>";
echo $frutas[1]; // Banana
echo "<br>";
echo $frutas[2]; // Laranja
echo "<br>";

$alunos = [
    ["nome" => "alvin", "idade" => 19],
    ["nome" => "simon", "idade" => 20],
    ["nome" => "theodore", "idade" => 18] 
];

echo $alunos[0]["nome"];
echo "<br>";
echo $alunos[0]["idade"];
echo "<br>";
echo $alunos[1]["nome"];
echo "<br>";
echo $alunos[1]["idade"];
echo "<br>";
echo $alunos[2]["nome"];
echo "<br>";
echo $alunos[2]["idade"];

echo "<br>Seu nome é ".$alunos[0]["nome"]. " e sua idade é ".$alunos[0]["idade"];
echo "<pre>";
var_dump($alunos);

?>