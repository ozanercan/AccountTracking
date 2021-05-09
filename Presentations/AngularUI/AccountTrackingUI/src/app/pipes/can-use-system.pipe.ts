import { Pipe, PipeTransform } from '@angular/core';
import { Messages } from '../constants/messages';

@Pipe({
  name: 'canUseSystem',
})
export class CanUseSystemPipe implements PipeTransform {
  transform(value: boolean): string {
    if (value == true) {
      return Messages.canUse;
    } else {
      return Messages.canNotUse;
    }
  }
}
