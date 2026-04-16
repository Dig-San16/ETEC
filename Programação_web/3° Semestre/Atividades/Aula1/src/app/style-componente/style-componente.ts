import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  standalone: true,
  selector: 'app-style-componente',
  imports: [CommonModule],
  templateUrl: './style-componente.html',
  styleUrl: './style-componente.css',
})
export class StyleComponente {
 
  //Variável booleano
  condicao:boolean=true;

  //lista de aprovados e reprovados
  lista:string[] = ['aprovado', 'reprovado', 'reprovado'];
}
