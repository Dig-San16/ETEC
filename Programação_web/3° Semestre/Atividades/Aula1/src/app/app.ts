import { Component, signal } from '@angular/core';
import { NgforComponente } from "./ngfor-componente/ngfor-componente";
import { NgSwitch } from "./ngswitch/ngswitch";
import { StyleComponente } from './style-componente/style-componente';
import { ɵEmptyOutletComponent } from "@angular/router";

@Component({
  selector: 'app-root',
  imports: [NgforComponente, NgSwitch, StyleComponente],
  templateUrl: './app.html',
  styleUrl: './app.css'
})

export class App {
  protected readonly title = signal('projeto04');
}
