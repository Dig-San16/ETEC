<?php include_once "header.php";?>

<form action="verificar.php" method="post">
    <label>e-mail</label>
    <input type="email" name="txt_email" required><br>
    <input type="password" name="txt_senha" required><br>
    <input type="submit" value="Login">
    
</form>

<?php include_once "footer.php"; ?>