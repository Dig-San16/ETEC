<?php
if(isset($_POST['txt_email'],$_POST['txt_senha']) && !empty($_POST['email']) && !empty($_POST['senha'])){
    $email=$_POST['txt_email'];
    $senha=$_POST['txt_senha'];
}else{
    header('Location:index2.php');
}
?>