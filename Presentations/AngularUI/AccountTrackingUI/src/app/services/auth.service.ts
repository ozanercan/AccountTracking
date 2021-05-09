import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AccessToken } from '../models/accessToken';
import { LoginResult } from '../models/loginResult';
import { DataResult } from '../models/Results/dataResult';
import { Result } from '../models/Results/result';
import { UserLogin } from '../models/userLogin';
import { UserRegister } from '../models/userRegister';
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
  private registerPath: string = 'Auth/Register';

  login(userLogin: UserLogin) {
    return this.httpClient.post<DataResult<LoginResult>>(
      this.loginPath,
      userLogin
    );
  }

  register(userRegister: UserRegister) {
    return this.httpClient.post<Result>(
      this.registerPath,
      userRegister
    );
  }

  /**
   * Kullanıcının giriş yapıp yapmadığını kontrol eder.
   * Giriş yaptıysa TRUE, Giriş yapmadıysa FALSE döner.
   */
  isLoggedIn(): boolean {
    let tokenResult = this.tokenService.get();
    if (tokenResult == null) {
      return false;
    }

    return true;
  }
}
