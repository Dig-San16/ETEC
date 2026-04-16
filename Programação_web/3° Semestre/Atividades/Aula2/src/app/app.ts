import { Component, signal } from '@angular/core';
import { BootstrapComponente } from './bootstrap-componente/bootstrap-componente';

@Component({
  selector: 'app-root',
  imports: [BootstrapComponente],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('sexto-projeto');
}
