/**
 * --------------------------------------------------------------------------
 *  Objects
 * --------------------------------------------------------------------------
 * 
 * São estruturas de dados que representam entidades, contendo propriedades que 
 * descrevem características ou comportamentos dessas entidades. As propriedades 
 * podem ser métodos (funções) ou valores.
 */ 

console.log('\n -------------- ATRIBUTO DINÂMICO');
const object = {
    getName() {
        return this?.name ?? "Objeto sem nome";
    }
}

console.log(object.getName());

object.name = "Otannael";

console.log("Método: " + object.getName(), "Atributo: " + object.name);

console.log('\n -------------- ATRIBUTO JÁ DEFINIDO');
let carro = {
    marca: "Toyota",
    modelo: "Corolla",
    ano: 2022,
    ligar: function() {
        console.log("O " + this.modelo + " está ligado.");
    }
};

carro.ligar();