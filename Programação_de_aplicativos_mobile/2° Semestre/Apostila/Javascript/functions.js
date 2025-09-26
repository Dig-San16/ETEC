/**
 * --------------------------------------------------------------------------
 *  Functions
 * --------------------------------------------------------------------------
 *  
 * São blocos de código reutilizáveis que podem ser chamados/executados para 
 * realizar uma tarefa específica. Elas podem receber parâmetros e retornar valores.
 */ 

function somar(a, b) {
    return a + b;
}

console.log(somar(1, 2)); 

function multiplicar(a, b) {
    console.log(a * b);
}

multiplicar(2,2); 

// Arrow fuction: Função curta e moderna.
// Funções Lambda: funções anônimas (não tem nome)

let subtrair = (a,b) => a-b; //Arrow function

const dividir = function(a,b){ //Lambda function
    return a/b;
}