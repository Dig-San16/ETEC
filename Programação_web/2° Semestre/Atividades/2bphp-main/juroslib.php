<?php

function jurosSimples($c,$i,$t){
    $j= $c*$i*$t;
    return $j;
}

function valorCapital($j,$i,$t){
    $c = $j/($i*$t);
    return $c;
}