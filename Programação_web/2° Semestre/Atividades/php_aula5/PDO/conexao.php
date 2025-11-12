<?php
//variáveis de configuração, aqui definimos o nome do servidor,
// do banco de dados, do usuário e da senha
$host = "localhost";
$dbname = "escola";
$user = "root";
$pass = "";

//A qualquer hora essa linha pode dar um erro, ent usamos try-catch
try {
    //cria-se um objeto que representa a conexão com o MySQL
    $pdo = new PDO (
    
    //O primeiro parâmetro é a DSN (Data Source Name), que informa ao 
    //PHP o driver(mysql), o servidor($host), o banco($dbname) e um 
    //chartset para acentuação e caracteres especiais(utf8)
    "mysql:
    host=$host;
    dbname=$dbname;
    charset=utf8", 

    //usuário e senha
    $user, 
    $pass
);

} catch (PDOException $e) {
    echo "Erro na conexão: " . $e->getMessage();
}
?>
