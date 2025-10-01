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
}

echo(new Pessoa("Leo", 20))->imprimirnome();

?>