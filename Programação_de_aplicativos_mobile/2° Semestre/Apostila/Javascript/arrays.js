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

console.log('\n -------------- ARRAYS --------------');

let lista = [];
for (let count = 0; count < 10; count++) {
    lista[count] = (count + 1) * 1;
    console.log("1 x " + (count + 1) + " = " + lista[count]);
}

console.log('\n -------------- MATRIZES --------------');

let matriz = [];
for (let linha = 0; linha < 10; linha++) {
    matriz[linha] = new Array(10);
    for (let coluna = 0; coluna < 10; coluna++) {
        matriz[linha][coluna] = (linha + 1) + " x " + (coluna + 1)  + " = " + (linha + 1) * (coluna + 1) + " \n";
    }
}
console.log(matriz);