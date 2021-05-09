import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/user';
import { HttpMessageCatchService } from 'src/app/services/http-message-catch.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-list-with-table',
  templateUrl: './user-list-with-table.component.html',
  styleUrls: ['./user-list-with-table.component.css'],
})
export class UserListWithTableComponent implements OnInit {
  constructor(
    private userService: UserService,
    private httpMessageCatchService: HttpMessageCatchService
  ) {}

  ngOnInit(): void {
    this.getUsers();
  }

  users!: User[];

  getUsers() {
    this.userService.getUsers().subscribe(
      (response) => {
        this.users = response.data;
        this.httpMessageCatchService.showSuccessMessage(response);
      },
      (responseError) => {
        this.httpMessageCatchService.showErrorMessage(responseError);
      }
    );
  }
}
