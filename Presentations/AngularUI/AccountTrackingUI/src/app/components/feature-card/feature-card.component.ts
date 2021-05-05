import { Component, Input, OnInit } from '@angular/core';
import { FeatureCard } from 'src/app/models/featureCard';

@Component({
  selector: 'app-feature-card',
  templateUrl: './feature-card.component.html',
  styleUrls: ['./feature-card.component.css'],
})
export class FeatureCardComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}

  @Input() featureCard!: FeatureCard;
}
