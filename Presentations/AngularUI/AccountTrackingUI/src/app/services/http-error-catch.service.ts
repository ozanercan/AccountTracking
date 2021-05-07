import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Result } from '../models/Results/result';

@Injectable({
  providedIn: 'root',
})
export class HttpErrorCatchService {
  constructor(private toastrService: ToastrService) {}

  getMessage(errorResponse: HttpErrorResponse) {
    if(errorResponse.error != null){
      let x = errorResponse.error as Result;
      this.toastrService.error(x.message);
    }
  }
}
