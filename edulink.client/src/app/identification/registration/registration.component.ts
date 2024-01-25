import { Component, OnInit } from '@angular/core';
import { User } from '../../models/User';
import { HttpClientHelper } from '../../services/HttpClientHelper.service';
import { API_ROUTES } from '../../constants/api-routes';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
    selector: 'app-registration',
    templateUrl: './registration.component.html',
    styleUrls: ['./registration.component.css'],
    standalone: true,
    imports: [FormsModule]
})
export class RegistrationComponent implements OnInit {
  registrationModel = new userRegistration();
  registrationFailed = false;

  constructor(private http: HttpClientHelper, private router: Router) {
  }

  ngOnInit() {
  }

  public registration() {
    if (this.registrationModel.password = this.registrationModel.confirmPassword) {
      const user = new User();
      user.email = this.registrationModel.email;
      user.password = this.registrationModel.password;

      this.http.postAsync<User>(API_ROUTES.USER_CREATION, user).subscribe((result: User) => {
        if (result.email == this.registrationModel.email) {
          this.registrationFailed = false;
          this.router.navigate(['/login']);
        }
      });
    } else {
      this.registrationFailed = true;
      console.log('error in registration');
    }
  }
}

export class userRegistration {
  email: string = "";
  password: string = "";
  confirmPassword: string = "";
}
