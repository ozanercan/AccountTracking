import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormArray,
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { UserLogin } from 'src/app/models/userLogin';
import { AuthService } from 'src/app/services/auth.service';
import { TitleService } from 'src/app/services/title.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css'],
})
export class LoginPageComponent implements OnInit {
  constructor(
    private titleService: TitleService,
    private formBuilder: FormBuilder,
    private userService: UserService,
    private authService: AuthService
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
      this.userService.login(loginModel).subscribe(
        (response) => {
          this.authService.save(response.data);
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
