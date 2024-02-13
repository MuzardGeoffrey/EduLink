import { Component, Input, OnInit, inject } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  standalone: true,
  imports: [FormsModule]
})
export class LoginComponent implements OnInit {
  authservice: AuthService;
  loginFailed = false;
  userModel = new UserLogin();

  constructor(private formBuilder: FormBuilder, private router: Router, authservice: AuthService) {
    this.authservice = authservice;
  }

  ngOnInit() {
  }

  login() {
    this.authservice.login(this.userModel.email, this.userModel.password).subscribe(
      (result: number) => {
        if (result > 0) {
          console.log("Login success");
          this.router.navigate(['/home']);
        } else {
          this.loginFailed = true;
          console.log("Login failed");
        }
      }
    );
  }
}

export class UserLogin {
  email: string = "";
  password: string = "";
}
