// let array = [1, 2, 3, 4, 5,];
// console.log(array[0]); //Acessando uma posição diretamente
// console.log(array[10 - 8]); //Acessando uma posição por uma conta
// array[5] = 10;
// console.log(array);
// array[5] = 152.1;
// console.log(array);

/**let matriz = [
    [1, 2, 3, 4, 5],
    [6, 7, 8, 9, 10],
    [11, 12, 13, 14, 15]
];

console.log(matriz[0])*/

/**
 * Exercicio - Calcular a tabuada do 1 ao 10 usando uma matriz. Lembre-se
 * uma matriz é um array dentro de outro, [[], [], []]
 */
 
//let arr = [];
//let exp = new Array();

let matriz = [
[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
];


for (matriz[0]=1; matriz[0]<11; matriz[0] += 1){

    for (matriz[1]=1; matriz[1]<11; matriz[1] += 1){
        soma = matriz[0] * matriz[1];
        array = [];
        array.push(soma);
        console.log(array);
    }   
}

