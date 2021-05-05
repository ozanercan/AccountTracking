import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TitleService {

  constructor() { }

  private prefix: string = '';
  private suffix: string = ' | Hesap Takip Yazılımı';
  set(title:string) {
    document.title = this.prefix + title + this.suffix;
  }
}
