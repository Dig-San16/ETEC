<?php 
include "juroslib.php";

if($_POST["c"]>0){
$J=jurosSimples($_POST["c"],$_POST["i"],$_POST["t"]);
echo "Montante Total:".$J;

} else{ 

$C = valorCapital($_POST["j"],$_POST["i"],$_POST["t"]);
echo "Capital: ".$C;
}
