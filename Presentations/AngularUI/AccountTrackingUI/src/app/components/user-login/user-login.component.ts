import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { timer } from 'rxjs';
import { Messages } from 'src/app/constants/messages';
import { Settings } from 'src/app/constants/settings';
import { UserLogin } from 'src/app/models/userLogin';
import { AuthService } from 'src/app/services/auth.service';
import { HttpMessageCatchService } from 'src/app/services/http-message-catch.service';
import { TitleService } from 'src/app/services/title.service';
import { TokenService } from 'src/app/services/token.service';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css'],
})
export class UserLoginComponent implements OnInit {
  constructor(
    private titleService: TitleService,
    private formBuilder: FormBuilder,
    private authService: AuthService,
    private tokenService: TokenService,
    private toastrService: ToastrService,
    private router: Router,
    private httpMessageCatchService: HttpMessageCatchService
  ) {}

  ngOnInit(): void {
    this.titleService.set('Giriş Yap');

    this.createLoginForm();
  }

  loginForm!: FormGroup;

  loginProcessContinuing: boolean = false;

  get getEmail(): FormArray {
    return this.loginForm.get('email') as FormArray;
  }

  get getPassword(): FormArray {
    return this.loginForm.get('password') as FormArray;
  }

  createLoginForm() {
    this.loginForm = this.formBuilder.group({
      email: [
        '',
        [Validators.required, Validators.minLength(2), Validators.email],
      ],
      password: ['', [Validators.required, Validators.minLength(2)]],
    });
  }

  onSubmit() {
    if (this.loginForm.valid) {
      this.loginProcessContinuing = true;
      let loginModel: UserLogin = this.loginForm.value;
      this.authService.login(loginModel).subscribe(
        (response) => {
          this.tokenService.save(response.data.accessToken);
          
          this.toastrService.success(Messages.loginSuccessfully);

          this.toastrService.info(Messages.redirectToUserMainPage);

          timer(Settings.redirectUserPageSecond * 1000).subscribe((p) =>
            this.router.navigateByUrl('management/home')
          );
        },
        (error: HttpErrorResponse) => {
          this.loginProcessContinuing = false;
          this.httpMessageCatchService.showErrorMessage(error);

        },
        () => {
          this.loginProcessContinuing = false;
        }
      );
    }
  }
}
