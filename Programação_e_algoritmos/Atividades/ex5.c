#include <stdio.h>
#include <stdlib.h>

void main() {
	int temperatura;
	int fahrenheit;
	printf("digite uma temperatura em celsius para ser convertida em fareinheit: ");
	scanf("%d", &temperatura);
	fahrenheit = (temperatura*9)/5+32;
	printf("A temperatura %d celsius em fahrenheit é %d\n", temperatura, fahrenheit);
}
