
/**
 * --------------------------------------------------------------------------
 *  Condições
 * --------------------------------------------------------------------------
 * 
 * São estruturas de código que dada uma determinada condição, se satisfeita
 * executarão determinado bloco de código.
 */ 

console.log('\n -------------------IF ELSE-------------------');

const idade = 22;
if (idade < 18) {
    console.log('Você ainda não pode tirar CNH');
} else if (idade >= 18 || idade <= 25) {
    console.log('Você já pode tirar CNH');
} else {
    console.log('Hmm, não tenho opções para sua idade');
}


console.log('\n -------------------SWITCH CASE DEFAULT-------------------');

let fruta = 'Maçãs';
switch (fruta) {
    case "Laranjas":
        console.log("As laranjas custam R$ 0,59 o quilo.");
        break;
    case "Maçãs":
        console.log("Maçãs custam R$ 0,32 o quilo.");
        break;
    case "Bananas":
        console.log("Bananas custam R$ 0,48 o quilo.");
        break;
    case "Mamões":
        console.log("Mangas e mamões custam R$ 2,79 o quilo.");
        break;
    default:
        console.log("Desculpe, estamos sem nenhuma " + expr + ".");
}