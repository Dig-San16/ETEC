//código que imprime toda a tabuada de 1 a 10

for (count = 1; count < 11; count += 1){
    console.log(`\ntabuada do ${count}\n`);
    for (count2 = 1; count2 < 11; count2 += 1){
        soma = count * count2;
        console.log(`${count} x ${count2} = ${soma}`);
    }
}

//código que identifica 3 tipos de triangulos (equilatero, escaleno e isosceles) através do valor de seus
//lados

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


