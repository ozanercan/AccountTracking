import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { TokenService } from '../services/token.service';
import { AuthService } from '../services/auth.service';

@Injectable()
export class AuthorizationIncluderInterceptor implements HttpInterceptor {
  constructor(private authService:AuthService, private tokenService:TokenService) {}

  intercept(
    request: HttpRequest<unknown>,
    next: HttpHandler
  ): Observable<HttpEvent<unknown>> {
    if(this.authService.isLoggedIn()){
      let newRequest: HttpRequest<any> = request.clone({
        headers: request.headers.set(
          'Authorization',
          'Bearer ' + this.tokenService.get()?.token
        ),
      });
      return next.handle(newRequest);
    }
    return next.handle(request);
  }
}
