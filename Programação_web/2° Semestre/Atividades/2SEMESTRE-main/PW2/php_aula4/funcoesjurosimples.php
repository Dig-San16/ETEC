<?php

function calcularJurosSimples($capital, $taxa, $tempo) {
    $juros = ($capital * $taxa * $tempo) / 100;
    return $juros;
}

function calcularmontante($capital, $taxa, $tempo) {
    $montante = ($capital + $juros);
    return $montante;
}

?>