<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="calculadora.php" method="POST">
        <label for="num1">Número 1</label>
        <input type="number" name="num1">
        <label for="num2">Número 2</label>
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
    class Calculadora {
        private $num1;
        private $num2;

        public function __construct($num1, $num2) {
            $this->num1 = $num1;
            $this->num2 = $num2;
        }

        public function adicao() {
            return $this->num1 + $this->num2;
        }

        public function subtracao() {
            return $this->num1 - $this->num2;
        }

        public function multiplicacao() {
            return $this->num1 * $this->num2;
        }

        public function divisao() {
            if ($this->num2 == 0) {
                return "Não se divide por 0!";
            }
            return $this->num1 / $this->num2;
        }

        public function calcular($operacao) {
            switch ($operacao) {
                case "adicao":
                    return $this->adicao();
                case "subtracao":
                    return $this->subtracao();
                case "multiplicacao":
                    return $this->multiplicacao();
                case "divisao":
                    return $this->divisao();
                default:
                    return "Selecione a operação.";
            }
        }
    }


    if (isset($_POST["num1"], $_POST["num2"], $_POST["operacao"])) {
        $num1 = $_POST["num1"];
        $num2 = $_POST["num2"];
        $operacao = $_POST["operacao"];

        $calc = new Calculadora($num1, $num2);
        echo "Resultado: " . $calc->calcular($operacao);
    }
    ?>
</body>
</html>


