import { Component, HostListener, OnInit } from '@angular/core';
import { MatSidenavModule } from '@angular/material/sidenav';
import { RouterOutlet } from '@angular/router';
import { RigthbarComponent } from './rigthbar/rigthbar.component';
import { LeftbarComponent } from './leftbar/leftbar.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  standalone: true,
  imports: [MatSidenavModule,RouterOutlet, RigthbarComponent, LeftbarComponent]
})
export class HomeComponent implements OnInit {

  ngOnInit() {
  }

}
