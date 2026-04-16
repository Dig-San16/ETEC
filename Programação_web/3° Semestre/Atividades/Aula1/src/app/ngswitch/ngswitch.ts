import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  standalone: true,
  selector: 'app-ngswitch',
  imports: [CommonModule],
  templateUrl: './ngswitch.html',
  styleUrl: './ngswitch.css',
})

export class NgSwitch {

  linguagem:string = 'HTML';

}
