<?php

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
?>