const pessoa = {
    nome: "Pamela",
    idade: 30,
    apelido: "Pam",
    cidade: "Diadema",
    formacao: "DS",
    sexo: "Feminino",

    imprimirnome: function(){
        return `${this.nome}`
    }
}
    
    
console.log(pessoa.imprimirnome());

const veiculo = {
    modelo: "Clio",
    ano: 2004,
    marca: "Renault",

    imprimirano: function(){
        return `${this.ano}`
    }
}

console.log(veiculo.imprimirano())