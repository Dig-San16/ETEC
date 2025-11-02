<?php
        $n1 = $_POST["n1"];
        $n2 = $_POST["n2"];
        $operacao = $_POST["operacao"];

        function soma ($n1, $n2){
            $resultado = $n1 + $n2;
            return $resultado;
        }

        function subtrair ($n1, $n2){
            $resultado = $n1 - $n2;
            return $resultado;
        }

        function multiplicar ($n1, $n2){
            $resultado = $n1 * $n2;
            return $resultado;
        }

        function dividir ($n1, $n2){
            $resultado = $n1 / $n2;
            return $resultado;
            if($n2 == 0){
                return "Operação inválida";
            }
            
        } 
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

        
