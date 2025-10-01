<?php
class Pessoa {
    public $nome;
    public $idade;

    public function __construct($nome, $idade)
    {
        $this->nome = $nome;
        $this->idade = $idade;
    }

    public function imprimirnome()
    {
        return $this->$nome ."tem". $this->$idade;
    }

    public function dormir()
    {
        return true;
    }

    public function beber()
    {
        return false;
    }
}
    $pessoa = new Pessoa("Pamela", 30);
    
echo $pessoa->nome;
echo $pessoa->idade;
echo $pessoa->dormir();
?>