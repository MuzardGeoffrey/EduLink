import { Component, ViewChild } from '@angular/core';
import { RouterLink, RouterOutlet, Router } from '@angular/router';
import { MatMenuModule, MatMenuTrigger } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
  standalone: true,
  imports: [RouterOutlet, RouterLink, MatMenuModule, MatIconModule]
})
export class NavbarComponent {
  @ViewChild(MatMenuTrigger)
  trigger!: MatMenuTrigger;
  public isCollapsed = true;
  private lastPoppedUrl: string | undefined;
  private yScrollStack: number[] = [];

  constructor(private router: Router) {
  }

  ngOnInit() {
  }

  someMethod() {
    this.trigger.openMenu();
  }
}
