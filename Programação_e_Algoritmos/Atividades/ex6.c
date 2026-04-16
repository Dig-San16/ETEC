#include <stdio.h>
#include <stdlib.h>

void main() {
	int num;
	int dobro;
    printf("digite um número: ");
	scanf("%d", &num);
	dobro = num*2;
	printf("o dobro de %d é: %d\n", num, dobro);
}
