import { Component, OnInit } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { FooterComponent } from './shared/footer/footer.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { HomeComponent } from './home/home.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  standalone: true,
  imports: [
    RouterLink,
    RouterOutlet,
    FooterComponent,
    NavbarComponent
  ]
})
export class AppComponent implements OnInit {
  constructor() { }

  ngOnInit() {
  }
  title = 'edulink.client';
}
