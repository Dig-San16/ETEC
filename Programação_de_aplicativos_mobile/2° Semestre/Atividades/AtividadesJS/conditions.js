/**
 * -------------
 * EXERCICIOS
 * -------------
 * 1- Dada as variáveis x = 1 e y = 5, faça um algoritmo em Javascript que inverte os valores, ou seja, no fim, x 
 * deve ficar com 5 e y com 1;
 * 
 * 2- Um triângulo possui 3 lados, faça um algoritmo que indique se um triângulo é equilatero, 
 * isóceles e escaleno. Equilatero possui todos os lados iguais, escaleno possui todos os lados diferentes 
 * e isoceles possui ao menos um lado diferente.
 * 
 */


//1
let x = 1;
let y = 5;
let z = 0;

z = x;
x = y;
y = z;

console.log(`x = ${x} e y = ${y}`);


//2
let lado1 = 5;
let lado2 = 4;
let lado3 = 3;


if (lado1 == lado2 && lado1 == lado3){
    console.log(`os lados com as medidas ${lado1} ${lado2} e ${lado3} formam um triangulo equliatero`);
} else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3){
    console.log(`os lados com as medidas ${lado1} ${lado2} e ${lado3} formam um triangulo escaleno`);
} else {
    console.log(`os lados com as medidas ${lado1} ${lado2} e ${lado3} formam um triangulo isosceles`);
}

num = [1, 5];

console.log(num.reverse());

