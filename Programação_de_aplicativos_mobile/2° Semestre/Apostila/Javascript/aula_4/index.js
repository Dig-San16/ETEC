//Funções
function somar(a, b){
    return a + b;
}

const dividir = function (a, b){ //lambda funcition
    return a / b
}

function multiplicar(a, b){
    return a * b
}

const subtrair = (a, b) => a - b //arrow function

console.log(somar(50, 50), dividir(10, 5), subtrair(7, 2), multiplicar(8, 10));

function calculadora(operacao, a, b) {
    switch (operacao) {
        case 'somar':
            console.log(somar(a, b))
            break
        case 'dividir':
            console.log(dividir(a, b))
            break
        case 'subtrair':
            console.log(subtrair(a, b))
            break
        case 'multiplicar':
            console.log(multiplicar(a, b))
            break
        default:
            console.log("Operação inexistente")
            break
    }
    return
}
    
calculadora('somar', 50, 50)
calculadora('dividir', 10, 5)
calculadora('subtrair', 7, 2)
calculadora('multiplicar', 8, 10)

/**
 * EXERCÍCIO
 * 1 - Crie uma função que receba um parâmetro e retorne a tabuada desse número; detalhe: use um laço de repetição.
 * 2 - Crie uma função que receba um parâmetro que indique quantos e quais números da sequência Fibonnaci deve ser retornado.
 * 3 - Crie uma função que receba um array e retorne seu tamanho, ou seja, quantos elementos um array possui dentro dele.
*/

/*1- */function multiplicar(a, b){
    return a * b
}

function calculadora(operacao, a, b){
    for (a = 1; a < 11; a++){
    console.log("\nTabuada do " + a + "\n");
    for (b = 1; b < 11; b++) {
        operacao = b * a;
        console.log(a + " x " + b + " = " + operacao);
}
}
}

/* 2- */ function Fibonnaci(limit){
    let start = 1
    let end = 0
    let sequence = 0

    console.log(`Os ${limit} primeiros de Fibonnaci são: `)
    for(let count = 1; count <= limit; count++){
        console.log(end)
        sequence = start + end
        end = start
        start = sequence
    }
    }
Fibonnaci(10)

/* 3- */ const arrayLength = (arr) => {console.log(arr.length)}
        arrayLength(new Array(10))


