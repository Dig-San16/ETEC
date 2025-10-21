/**
 * Exercicio:
 * Modele uma classe/objeto de um produto de uma papelaria
 * esse produto precisa ter como atributos: nome e preço
 * e um metodo que calcule o valor de uma venda quando 
 * passados uma quantidade como parâmetro */

let papelaria = {
    product: "Pacote Papel Sulfite",
    price: 40,
    calculo: function (quantity){
        return  quantity * this.price;
    }
}

console.log(`Produto: ${papelaria.product}. Valor: ${papelaria.price}`);
console.log(`total da venda de 20 pacotes: ${papelaria.calculo(5)}`);