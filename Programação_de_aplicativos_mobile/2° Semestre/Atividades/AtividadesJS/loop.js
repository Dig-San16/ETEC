/*
-------------
EXERCICIO
-------------
*/

// Monte um algoritmo que calcula a tabuada do 1 ao 10
// usando algum dos laços de repetição apresentados


//FOR
for (count1 = 1; count1 < 11; count1++){
    console.log("\nTabuada do " + count1 + "\n");
    for (count2 = 1; count2 < 11; count2++) {
        soma = count1 * count2;
        console.log(count1 + " x " + count2 + " = " + soma);
    }
}

console.log("\n")


//DO WHILE
let count3 = 1;
do{
    console.log(`\nTabuada do ${count3}`);
    let count4 = 1;
    do{
        console.log(`${count3} x ${count4} = ${count3 * count4}`);
        count4++;
    } while (count4<11);
    count3++;
} while(count3<11);
