/*
for (count=1; count<11; count += 1){
    console.log(`\nTabuada do ${count}\n`);
    for (count2=1; count2<11; count2 += 1){
        console.log(`${count} x ${count2} = ${count * count2}`);
    }
}
*/

let count3 = 1;
do{
    console.log(`Tabuada do ${count3}`);
    do{
        let count4 = 1;
        console.log(`${count3} x ${count4} = ${count3 * count4}`);
    } while (count4<11);
} while(count3<11);

/*

while(count5 <= 10){
    let = count6 
    while (count6 <= 10){

    }
        
}

*/