import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { AccessToken } from '../models/accessToken';
import { LoginResult } from '../models/loginResult';
import { DataResult } from '../models/Results/dataResult';
import { Result } from '../models/Results/result';
import { User } from '../models/user';
import { UserLogin } from '../models/userLogin';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor(
    private httpClient: HttpClient,
    private toastrService: ToastrService
  ) {}

  private listPath: string = 'Users/GetList';

  getUsers(): Observable<DataResult<User[]>> {
    return this.httpClient.get<DataResult<User[]>>(this.listPath);
  }
}
