<?php
    include_once 'header.php';
    include_once 'protecao.php';
    ?>
<h2>Nome:<?php echo $_SESSION['user']['name'];?></h2>
<a href="sair.php">Logout</a>
    <?php
    include_once 'footer.php';
?>