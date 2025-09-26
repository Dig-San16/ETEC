#include <stdio.h>
#include <stdlib.h>
#define taxa 5.20

void main() {
	float real, dolar;
	printf("digite o numero em dólar para ser convertido em real: ");
        scanf("%f", &dolar);
	real = dolar * 5.68;
	printf("O valor %.2f convertido em dólar dará: %.2f\n", dolar, real);	
}
