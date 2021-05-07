import { Injectable } from '@angular/core';
import { AccessToken } from '../models/accessToken';

@Injectable({
  providedIn: 'root'
})
export class TokenService {

  constructor() { }

  private accessTokenKey: string = 'accessToken';
  save(accessToken: AccessToken) {
    localStorage.setItem(this.accessTokenKey, JSON.stringify(accessToken));
  }

  get(): AccessToken | null {
    let localStorageResult = localStorage.getItem(this.accessTokenKey);
    if(localStorageResult == null){
      return null;
    }

    return JSON.parse(localStorageResult);
  }

  remove(){
    localStorage.removeItem(this.accessTokenKey);
  }
}
