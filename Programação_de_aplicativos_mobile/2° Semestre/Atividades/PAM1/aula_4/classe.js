const pessoa = {
    nome: "Pamela",
    idade: 30,
    imprimirNome: function (){
        return `${this.nome} tem ${this.idade} anos`
    },
    beber: function(){
        return true
    }
};

console.log(pessoa, pessoa.imprimirNome());