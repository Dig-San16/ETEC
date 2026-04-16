import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  standalone: true,
  selector: 'app-bootstrap-componente',
  imports: [FormsModule],
  templateUrl: './bootstrap-componente.html',
  styleUrl: './bootstrap-componente.css',
})
export class BootstrapComponente {
  nome:string="";
  cidade:string="";
}




















