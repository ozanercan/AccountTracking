import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'AccountTrackingUI';

  ngOnInit(): void {
    if (document.URL.indexOf('user/') != -1) {
      this.onTheUserPage = true;
    }
  }

  onTheUserPage: boolean = false;
}
