var nome = "texto"; //string
let idade = 25; //number
const documento = "12"; //string
/*idade = 25.1; //number or float
idade = false; //boolean
idade = {} //object
idade = () => {} //function
idade = [] //array
 */
console.log(documento);
//documento = "novo";
//console.log(documento);

//IF, ELSE IF e ELSE
if (idade >= 18 || idade <= 24) { //condição 1
    //se verdadeiro
    console.log("é maior de idade");
} else if (idade >= 25) { //condição 2
    console.log("é maior de idade - adulto");
} else {
    //se falso/não entender a condição
    console.log("é menor de idade");
}

//SWITCH CASE
switch (idade) {
    case 25:
        console.log("Sua classificação é ouro");
        break;
    case 26:
        console.log("Sua classificação é prata");
        break;
    case 27:
        console.log("Sua classificação é bronze");
        break;
    default:
        console.log("Impossivel definir sua classificação");
        break;
}

/**
 * -------------
 * EXERCICIOS
 * -------------
 * 1- Dada as variáveis x = 1 e y = 5, faça um algoritmo em Javascript que inverte os valores, ou seja, no fim, x deve ficar com 5 e y com 1;
 * 
 * 2- Um triângulo possui 3 lados, faça um algoritmo que indique se um triângulo é equilatero, isóceles e escaleno. Equilatero possui todos os lados iguais, escaleno possui todos os lados diferentes e isoceles possui ao menos um lado diferente.
 * 
 */

let x = 1;
let y = 5;
let z = 0;

z = x;
x = y;
y = z;

console.log(`x = ${x} e y = ${y}`);

let ladoA = 5;
let ladoB = 8;
let ladoC = 5;

if (ladoA == ladoB && ladoA == ladoC) {
    console.log(`é um triangulo equilatero`);
} else if (ladoA != ladoB && ladoB != ladoC && ladoA != ladoC) {
    console.log(`é um triangulo escaleno`);
} else {
    console.log(`é um triangulo isosceles`);
}

num = [1, 5];

console.log(num.reverse());

