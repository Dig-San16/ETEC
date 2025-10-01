<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
     <form action="calculadora.php" method="POST">
        <label for="num1">numero 1</label>
        <input type="number" name="num1">
        <label for="num2">numero 2</label>
        <input type="number" name="num2">
        <select name="operacao">
            <option value="adicao">+</option>
            <option value="subtracao">-</option>
            <option value="multiplicacao">x</option>
            <option value="divisao">/</option>
        </select>
        <input type="submit" value="Enviar">
        <input type="reset" value="Limpar">

        <textarea name="mensagem" rows="1">não ligue para isso</textarea>
    </form>

    <?php
    if (isset($_POST["num1"]) && isset($_POST["num2"]) && isset($_POST["operacao"])) {
        $num1 = $_POST["num1"];
        $num2 = $_POST["num2"];
        $operacao = $_POST["operacao"];

        function adicao($num1, $num2){
            return $num1 + $num2;
        }
        function subtracao($num1, $num2){
            return $num1 - $num2;
        }
        function multiplicacao($num1, $num2){
            return $num1 * $num2;
        }
        function divisao($num1, $num2){
            if ($num1 == 0 || $num2 == 0){
                echo "não se divide por 0";
            } else{
                return $num1 / $num2;
            }
        }

        switch($operacao){
            case "adicao":
                echo adicao($num1, $num2);
                break;
            case "subtracao":
                echo subtracao($num1, $num2); 
                break;
            case "multiplicacao":
                echo multiplicacao($num1, $num2); 
                break;
            case "divisao":
                echo divisao($num1, $num2);  
                break;
            default:
                echo "selecione a operação";
                break;
        }
    }
    ?>
</body>
</html>