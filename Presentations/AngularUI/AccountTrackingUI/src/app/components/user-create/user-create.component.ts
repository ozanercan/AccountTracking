import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Messages } from 'src/app/constants/messages';
import { Result } from 'src/app/models/Results/result';
import { UserLogin } from 'src/app/models/userLogin';
import { UserRegister } from 'src/app/models/userRegister';
import { AuthService } from 'src/app/services/auth.service';
import { HttpMessageCatchService } from 'src/app/services/http-message-catch.service';
import { TitleService } from 'src/app/services/title.service';
import { TokenService } from 'src/app/services/token.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-create',
  templateUrl: './user-create.component.html',
  styleUrls: ['./user-create.component.css'],
})
export class UserCreateComponent implements OnInit {
  constructor(
    private titleService: TitleService,
    private formBuilder: FormBuilder,
    private userService: UserService,
    private authService: AuthService,
    private tokenService: TokenService,
    private httpMessageCatchService: HttpMessageCatchService,
    private toastrService:ToastrService
  ) {}

  ngOnInit(): void {
    this.createRegisterForm();
  }
  registerForm!: FormGroup;

  registerProcessContinuing: boolean = false;

  get getFirstName(): FormArray {
    return this.registerForm.get('firstName') as FormArray;
  }
  get getLastName(): FormArray {
    return this.registerForm.get('lastName') as FormArray;
  }
  get getDegree(): FormArray {
    return this.registerForm.get('degree') as FormArray;
  }

  get getEmail(): FormArray {
    return this.registerForm.get('email') as FormArray;
  }

  get getPassword(): FormArray {
    return this.registerForm.get('password') as FormArray;
  }
  get getPasswordAgain(): FormArray {
    return this.registerForm.get('passwordAgain') as FormArray;
  }
  get getCanUseSystem(): FormArray {
    return this.registerForm.get('canUseSystem') as FormArray;
  }

  createRegisterForm() {
    this.registerForm = this.formBuilder.group({
      email: [
        '',
        [Validators.required, Validators.minLength(2), Validators.email],
      ],
      password: ['', [Validators.required, Validators.minLength(2)]],
      passwordAgain: ['', [Validators.required, Validators.minLength(2)]],
      firstName: ['', [Validators.required, Validators.minLength(2)]],
      lastName: ['', [Validators.required, Validators.minLength(2)]],
      degree: ['', [Validators.required, Validators.minLength(2)]],
      canUseSystem: ['', [Validators.required]],
    });
  }

  onSubmit() {
    if (this.registerForm.valid) {
      this.registerProcessContinuing = true;
      let registerModel: UserRegister = this.registerForm.value;
      this.authService.register(registerModel).subscribe(
        (response) => {
          this.toastrService.success(Messages.registerSuccessByUser);
        },
        (error: HttpErrorResponse) => {
          this.registerProcessContinuing = false;
          this.httpMessageCatchService.showErrorMessage(error);
        },
        () => {
          this.registerProcessContinuing = false;
        }
      );
    }
  }
}
