import { Component, OnInit } from '@angular/core';
import { User } from '../../models/User';
import { HttpClientHelper } from '../../services/HttpClientHelper.service';
import { API_ROUTES } from '../../constants/api-routes';
import { AuthService } from '../../services/auth.service';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-detail-profile',
  templateUrl: './detail-profile.component.html',
  styleUrls: ['./detail-profile.component.css'],
  standalone: true,
imports: [RouterLink, RouterOutlet]
})
export class DetailProfileComponent implements OnInit {
  user = new User;
  constructor(private http: HttpClientHelper, private auth: AuthService) { }

  ngOnInit() {
    this.http.getAsync<User>(`${API_ROUTES.USER_DETAILS}${this.auth.userId}`).subscribe((result: User) => {
      this.user = result;
    });
  }
}
