import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { HttpClientHelper } from '../services/HttpClientHelper';
import { first } from 'rxjs/operators';
import { User } from '../models/User';
import { API_ROUTES } from '../constants/api-routes';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  focus: any;
  focus1: any;
  loginForm: FormGroup = this.formBuilder.group({
    username: ['', Validators.required],
    password: ['', Validators.required]
  });

  registerForm: FormGroup = this.formBuilder.group({
    username: ['', Validators.required],
    password: ['', Validators.required],
    confirmPassword: ['', Validators.required]
  });

  httpClientHelper: HttpClientHelper;

  constructor(private formBuilder: FormBuilder, private router: Router, httpClientHelper: HttpClientHelper) {
    this.httpClientHelper = httpClientHelper;
  }

  ngOnInit() {
  }

  login() {
    if (this.loginForm.valid) {
      this.httpClientHelper.postAsync<User>(API_ROUTES.VERIFICATION, this.loginForm.value).pipe(first()).subscribe({
        next: () => {
          console.log('Login successful');
          this.router.navigate(['/home']);
        },
        error: () => {
          console.error('Login failed');
        }
      });
    }
  }

  register() {
    if (this.registerForm.valid) {
      this.httpClientHelper.postAsync<User>(API_ROUTES.USER_CREATION, this.registerForm.value).pipe(first()).subscribe({
        next: () => {
          console.log('Registration successful');
          this.router.navigate(['/home']);
        },
        error: () => {
          console.error('Registration failed');
        }
      });
    }
  }
}
