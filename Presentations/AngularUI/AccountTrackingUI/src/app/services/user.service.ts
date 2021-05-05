import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { AccessToken } from '../models/accessToken';
import { DataResult } from '../models/Results/dataResult';
import { Result } from '../models/Results/result';
import { UserLogin } from '../models/userLogin';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor(
    private httpClient: HttpClient,
    private toastrService: ToastrService
  ) {}

  private loginPath: string = 'Auth/Login';

  login(userLogin : UserLogin){
    return this.httpClient.post<DataResult<AccessToken>>(this.loginPath, userLogin);
  }
}
