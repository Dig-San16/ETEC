<?php
include "funcoesjurosimples.php";

$capital = $_POST["capital"];
$tempo = $_POST["tempo"];
$taxa = $_POST["taxa"];
$juros = calcularJurosSimples($capital, $taxa, $tempo);
$montante = calcularmontante(calcularJurosSimples($juros, $capital, $taxa, $tempo));

echo calcularJurosSimples($juros, $capital, $taxa, $tempo);
echo calcularmontante();
?>