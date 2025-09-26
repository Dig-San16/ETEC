let a = Number(prompt(`Digite o valor de a: `));
let b = Number(prompt(`Digite o valor de b: `));
let c = Number(prompt(`Digite o valor de c: `));

let delta = Math.pow(b, 2) - 4 * a * c;

if (delta > 0) {
    let r1 = (-b + Math.sqrt(delta)) / (2 * a); 
    let r2 = (-b - Math.sqrt(delta)) / (2 * a); 
    document.writeln(`Primeira raiz: ${r1}<br>Segunda raiz: ${r2}`);
} else if (delta == 0) {
    let r = -b / (2 * a);
    document.writeln(`Raiz única: ${r}`);
} else {
    document.writeln(`Não possuem raízes reais.`);
}







