import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { MediaPipe } from '../pipe/media-pipe';

@Component({
  standalone: true,
  selector: 'app-pipe-projeto',
  imports: [CommonModule, MediaPipe],
  templateUrl: './pipe-projeto.html',
  styleUrl: './pipe-projeto.css',
})

export class PipeProjeto {

  //variáveis
  nome: string = 'Tomas';
  curso1: string = 'Segurança da Informação';
  curso2: string = 'Ciência da Computação';
  profissao: string = 'Coletor de Lixo';
  dados_pessoais: any = {'nome': 'Tomas', 'idade': 25, 
  'cidade': 'São Paulo', 'Estado': 'SP'};


  //vetor de objetos
  alunos: any[] = [
    {'nome': 'Tomas', 'nota1': 5, 'nota2': 9, 'nota3': 9, 'nota4': 7},
    {'nome': 'Kika', 'nota1': 7, 'nota2': 9, 'nota3': 10, 'nota4': 7},
    {'nome': 'Lambo', 'nota1': 4, 'nota2': 6, 'nota3': 9, 'nota4': 3},
    {'nome': 'Goose', 'nota1': 9, 'nota2': 8, 'nota3': 10, 'nota4': 8},
    {'nome': 'Gema', 'nota1': 5, 'nota2': 9, 'nota3': 9, 'nota4': 7}
  ];


  //vetor de objetos
  vendas: any[] = [
    {'nome': 'Cool', 'janeiro': 45400, 'fevereiro': 39050, 'marco': 39546},
    {'nome': 'Seaman', 'janeiro': 40435, 'fevereiro': 41345, 'marco': 40456},
    {'nome': 'Soquete', 'janeiro': 42046, 'fevereiro': 45670, 'marco': 38459}
  ];

}

