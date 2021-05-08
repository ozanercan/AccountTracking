import { Component, OnInit } from '@angular/core';
import { TitleService } from 'src/app/services/title.service';

@Component({
  selector: 'app-management-main-page',
  templateUrl: './management-main-page.component.html',
  styleUrls: ['./management-main-page.component.css'],
})
export class ManagementMainPageComponent implements OnInit {
  constructor(private titleService: TitleService) {}

  ngOnInit(): void {
    this.titleService.set('Ana Sayfa');
  }
}
