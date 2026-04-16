/*
----------------
Exercicio
----------------
*/

// Calcular a tabuada do 1 ao 10 usando uma matriz. Lembre-se
// uma matriz é um array dentro de outro, [[], [], []]
 
let arr = [];
let exp = new Array();

let matriz2 = [
[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
];


for (matriz2[0]=1; matriz2[0]<11; matriz2[0] += 1){

    for (matriz2[1]=1; matriz2[1]<11; matriz2[1] += 1){
        soma = matriz2[0] * matriz2[1];
        array = [];
        array.push(soma);
        console.log(array);
    }   
}

