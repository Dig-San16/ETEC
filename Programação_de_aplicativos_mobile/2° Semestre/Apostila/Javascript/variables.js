/**
 * --------------------------------------------------------------------------
 *  Variáveis
 * --------------------------------------------------------------------------
 *  
 * Dentro do JavaScript podemos declarar variáveis de três formas, usando as 
 * palavras reservadas var, let ou const. O JS não é uma linguagem fortemente
 * tipada, sendo assim, o tipo da variável será definido no momento em que um
 * valor for atribuido a ela, ou seja, ao definirmos a variável nome e 
 * atribuirmos uma string a ela, saberemos que esse é seu tipo pelo dado que 
 * foi inserido nela.
 * 
 * Relativo às declarações das variáveis temos:
 * - var, cria variáveis de escopo aberto e que podem ser sobrescritas;
 * - let, cria variáveis de escopo fechado, mas que pode ser sobrescrita;
 * - const, cria variáveis de escopo fechado e que não podem ser sobrescritas
 * após receberem um valor inicial.
 */ 
var nome = "William";

let sobrenome = "Sobral";

const idade = 25;

console.log(nome, sobrenome, idade);
