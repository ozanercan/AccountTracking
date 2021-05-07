import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AccessToken } from '../models/accessToken';
import { LoginResult } from '../models/loginResult';
import { DataResult } from '../models/Results/dataResult';
import { UserLogin } from '../models/userLogin';
import { TokenService } from './token.service';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(
    private tokenService: TokenService,
    private toastrService: ToastrService,
    private httpClient: HttpClient
  ) {}

  private loginPath: string = 'Auth/Login';

  login(userLogin: UserLogin) {
    return this.httpClient.post<DataResult<LoginResult>>(
      this.loginPath,
      userLogin
    );
  }

  /**
   * Kullanıcının giriş yapıp yapmadığını kontrol eder.
   * Giriş yaptıysa TRUE, Giriş yapmadıysa FALSE döner.
   */
  isLoggedIn():boolean {
    let tokenResult = this.tokenService.get();
    if(tokenResult == null){
      return false;
    }
    
    return true;
  }
}
