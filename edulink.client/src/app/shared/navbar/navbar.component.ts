import { Component } from '@angular/core';
import { RouterLink, RouterOutlet, Router, NavigationEnd, NavigationStart } from '@angular/router';
import { Location, PopStateEvent } from '@angular/common';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
  standalone: true,
  imports: [RouterOutlet, RouterLink]
})
export class NavbarComponent {
  public isCollapsed = true;
  private lastPoppedUrl: string | undefined;
  private yScrollStack: number[] = [];

  constructor(public location: Location, private router: Router) {
  }

  ngOnInit() {
    this.router.events.subscribe((event) => {
      this.isCollapsed = true;
      if (event instanceof NavigationStart) {
        if (event.url != this.lastPoppedUrl)
          this.yScrollStack.push(window.scrollY);
      } else if (event instanceof NavigationEnd) {
        if (event.url == this.lastPoppedUrl) {
          this.lastPoppedUrl = undefined;
          let last = this.yScrollStack.pop();
          if (last != undefined) {
            window.scrollTo(0, last);
          }
        } else
          window.scrollTo(0, 0);
      }
    });
    this.location.subscribe((ev: PopStateEvent) => {
      this.lastPoppedUrl = ev.url;
    });
  }

  ChangeCollapse() {
    this.isCollapsed = !this.isCollapsed;
  }
}
