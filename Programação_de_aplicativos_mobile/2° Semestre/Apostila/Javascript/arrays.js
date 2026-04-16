/**
 * --------------------------------------------------------------------------
 *  Arrays | Vetores | Listas 
 * --------------------------------------------------------------------------
 *  
 * São estruturas de dados que armazenam coleções de elementos, que podem ser 
 * de qualquer tipo, incluindo outros arrays. Os elementos são acessados por 
 * meio de índices (começando do zero).
 * 
 * --------------------------------------------------------------------------
 *  Matrizes
 * --------------------------------------------------------------------------
 * 
 * São arrays que contêm outros arrays como elementos. Eles são úteis para 
 * representar estruturas de dados mais complexas.
 */ 

console.log('\n -------------- Arrays | Vetores | Listas  --------------');

let array = [1, 2, 3, 4, 5,];

console.log(array[0]); //Acessando uma posição diretamente
console.log(array[10 - 8]); //Acessando uma posição por uma conta

array[5] = 10;
console.log(array);
array[5] = 152.1;
console.log(array);



console.log('\n -------------- Matrizes --------------');

let matriz = [
    [1, 2, 3, 4, 5],
    [6, 7, 8, 9, 10],
    [11, 12, 13, 14, 15]
];

console.log(matriz[0])


