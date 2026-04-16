import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  standalone: true,
  selector: 'app-ngfor-componente',
  imports: [CommonModule],
  templateUrl: './ngfor-componente.html',
  styleUrl: './ngfor-componente.css',
})

export class NgforComponente {
  //Vetor de nome
nome1:string[] = ["Ariane", "Bruna", "Caio", "Denis", "Priscila", "Don"]
nome2:string[] = ["Amarelo", "Mestiço", "Judeu", "Criolo", "Caucasiano", "Capixaba"]
nome3:number[] = [348975, 65457, 56465, 5456, 767654, 322]

}
