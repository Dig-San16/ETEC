import { Component, signal } from '@angular/core';
import { PipeProjeto } from "./pipe-projeto/pipe-projeto";

@Component({
  selector: 'app-root',
  imports: [PipeProjeto],
  templateUrl: './app.html',
  styleUrl: './app.css'
})

export class App {
  protected readonly title = signal('pipe-projeto');
}
