import { Component } from '@angular/core';
import { FormControl, FormsModule, FormGroup } from '@angular/forms';

@Component({
  standalone: true,
  selector: 'app-first-component',
  imports: [FormsModule],
  templateUrl: './first-component.html',
  styleUrl: './first-component.css',
})

export class FirstComponent {
  //objeto de formulario

  formulario= new FormGroup({
    nome: new FormControl(''),
    idade: new FormControl(null),
    cidade: new FormControl('')
  })
}
