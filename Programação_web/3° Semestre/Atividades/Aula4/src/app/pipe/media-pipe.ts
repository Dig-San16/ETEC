import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'media',
})
export class MediaPipe implements PipeTransform {
  transform(object: any): number {
    return (object.janeiro + object.fevereiro + object.marco) / 3;
  }
}
