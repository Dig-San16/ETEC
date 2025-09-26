#include <stdio.h>
#include <stdlib.h>

void main() {
	char nome[100];
	printf("Digite seu nome: ");
	scanf("%99s", nome);
	printf("olá %s\n", nome);
}
