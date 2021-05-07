import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UserLogin } from 'src/app/models/userLogin';
import { AuthService } from 'src/app/services/auth.service';
import { TitleService } from 'src/app/services/title.service';
import { TokenService } from 'src/app/services/token.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-create-page',
  templateUrl: './user-create-page.component.html',
  styleUrls: ['./user-create-page.component.css'],
})
export class UserCreatePageComponent implements OnInit {
  constructor(
    private titleService: TitleService,
    private formBuilder: FormBuilder,
    private userService: UserService,
    private authService: AuthService,
    private tokenService:TokenService
  ) {}

  ngOnInit(): void {
    this.titleService.set('Yeni Kullanıcı Oluştur');

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
        },
        (error) => {
          this.loginProcessContinuing = false;
        },
        () => {
          this.loginProcessContinuing = false;
        }
      );
    }
  }
}
