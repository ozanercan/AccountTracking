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

  constructor() {}
  
  ngOnInit(): void {}
}
