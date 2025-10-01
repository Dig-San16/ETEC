/*


// WHILE
while (count < 10) {
    console.log(count);
    count++;
}

// DO WHILE
do {
    console.log(count);
    count++;
} while (count < 20);

//FOR
for (count = 0; count < 10; count++) {
    console.log(count);
}

*/

for (count1 = 1; count1 < 11; count1++){
    console.log("\nTabuada do " + count1 + "\n");
    for (count2 = 1; count2 < 11; count2++) {
        soma = count1 * count2;
        console.log(count1 + " x " + count2 + " = " + soma);
    }
}

// Monte um algoritmo que calcula a tabuada do 1 ao 10
// usando algum dos laços de repetição apresentados