import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AccessToken } from '../models/accessToken';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private toastrService: ToastrService) {}

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
