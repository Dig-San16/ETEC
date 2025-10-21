/**
 * --------------------------------------------------------------------------
 *  Loops
 * --------------------------------------------------------------------------
 * 
 * São estruturas de código que dada uma condição e a marcação de um passo a 
 * passo, elas executam determinado trecho de código repetidas vezes.
 */ 

// Declaro um contador
var count = 0;

/**
 * O DO WHILE sempre executará ao menos uma vez o que estiver dentro do bloco
 * para então incrementar o contador e realizar a verificação da condição.
 */
console.log('\n -------------- DO WHILE --------------');
do { 
    console.log(count);
    count++
} while (count <= 3);

/**
 * O WHILE primeiro verifica a condição para então dar seguimento nas repetições, Diferente do DO WHILE.
 * Tanto WHILE quanto DO WHILE, a incrementação do contador costuma ficar por último.
 */
console.log('\n -------------- WHILE --------------');
while (count <= 3) {
    console.log(count);
    count++;
}

/**
 * o FOR Necessita de três parâmetros: declaração do contador; condição; passo a passo.
 */ 
console.log('\n -------------- FOR --------------');
for (var count = 0; count < 3; count++) {
    console.log(count);
}


