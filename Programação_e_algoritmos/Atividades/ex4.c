#include <stdio.h>
#include <stdlib.h>

void main() {
	float nota1;
	float nota2;
	float nota3;
	float media;
	printf("digite a nota do primeiro bimestre: ");
	scanf("%f", &nota1);
	printf("digite a nota do segundo bimestre: ");
	scanf("%f", &nota2);
	printf("digite a nota do terceiro bimestre: ");
	scanf("%f", &nota3);
	media = (nota1 + nota2 + nota3) / 3;
	if (media >= 7) {
		printf("Aprovado com %.2f na média!\n", media);
	}
	else {
		printf("Reprovado com %.2f na média!\n", media);	
	}
}
