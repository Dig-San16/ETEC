<?php

// TIPOS DE DADOS

$nome = "Mano";
$idade = 20;
$idades = "20";
echo "Boa noite, " .$nome;
echo "<br>Minha idade é: " .$idade;
echo "<br>A idade dela é: " .$idades;

// CONDIÇÕES

if ($idade == 18) {
    echo "<br>Maior<br>";
} elseif ($idade >= 19) {
    echo "<br>Maior e pode dirigir<br>";
} else {
   echo "Menor <br>";
}


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

// LAÇOS DE REPETIÇÃO

while($idade < 18){
    echo  "Você não tem idade para dirigir.<br>";
    echo "Idade atual: ".$idade;
    $idade++;
}

do{
    echo  "Você não tem idade para dirigir.<br>";
    echo "Idade atual: ".$idade;
    $idade = $idade +1;
}while ($idade < 18);


for($i=0; $i<10; $i++){
    echo "<br>Valor de i: ".$i;
}


//VETORES e MATRIZES

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
unset($alunos["idade"][1]);
echo "<br>Seu nome é ".$alunos[0]["nome"]. " e sua idade é ".$alunos[0]["idade"];
echo "<pre>";
var_dump($alunos);


//FUNÇÕES

//com parâmetro e sem retorno 
function mensagem1 ($nome){
    echo "<br>";
    echo "Boa noite," .$nome."! Não usar o celular";
}
mensagem1("Tom");

//com parâmetro e com retorno
function mensagem3($nome){
    echo "<br>";
    $msg = "Boa noite, " .$nome. "! Não use o celular.";
    return $msg;
} 
$msg = mensagem3("Tom");
echo $msg;


//sem parâmetro e sem retorno
function mensagem2 (){
    echo "<br>";
    echo "Boa noite! Não usar o celular";
}
mensagem2();

//sem parâmetro e com retorno
function mensagem4(){
    echo "<br>";
    return "Boa noite! Não use o celular.";
} 
echo mensagem4(); 


//função chamado a outra
function mensagem5(){
    echo "<br>";
    echo "Boa noite! Não use o celular.";
    function BoaNoite(){
        mensagem5();
        return "Boa noite!";
    } 
}
echo mensagem5(); 


