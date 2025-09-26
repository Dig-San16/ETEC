<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Juros simples</title>
</head>
<body>
    <?php include "menu.php";
    
    ?>
    <form action="resultadoJurosSimples.php" method="post">
    <pre>
    <label for="">Montante final</label>
    <input type="text" name="j" id="">
     <label for="">Capital Inicial</label>
    <input type="text" name="c" id="">
     <label for="">taxa</label>
    <input type="text" name="i" id="">
     <label for="">Tempo</label>
    <input type="text" name="t" id="">
    <input type="submit" value="Calcular">
    </form>
</body>
</html>
