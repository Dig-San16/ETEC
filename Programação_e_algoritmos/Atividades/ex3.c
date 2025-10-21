#include <stdio.h>
#include <stdlib.h>

void main() {
	int num1;
	int num2;
	int resultado;
	printf("digite um número: ");
	scanf("%d", &num1);
	printf("digite outro número: ");
	scanf("%d", &num2);
	resultado = num1 + num2;
	printf("Resultado: %d\n", resultado);
}
