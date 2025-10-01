<?php

include "funcoes_calculadora.php";

        $n1 = $_POST['n1'];
        $n2 = $_POST['n2'];
        $operacao = $_POST['operacao'];
     

        if($operacao == "soma"){
            echo "O resultado da soma é: " .soma($n1, $n2);
        } elseif($operacao == "subtrair"){
            echo "O resultado da subtração é: " .subtrair($n1, $n2);
        } elseif($operacao == "multiplicar"){
            echo "O resultado da multiplicação é: " .multiplicar($n1, $n2);
        } elseif($operacao == "dividir"){
            echo "O resultado da divisão é: " .dividir($n1, $n2);
        } else {
            echo "Operação inválida!";
        }
        ?>

        
