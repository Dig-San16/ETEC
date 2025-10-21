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

// tipos de declarações
var variável = 100;
let letar = 200;
const pi = 3.14;

// tipos de dados
let nome = "William"; //string

let idade = 25; //number

let num = 25.1; //float

let Evdd = false; //boolean

let objeto = {} //object

let lista = [] //array

console.log(nome, idade, num, Evdd, objeto, lista);

