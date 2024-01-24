import { Injectable } from '@angular/core';
import { HttpClientHelper } from './HttpClientHelper';
import { API_ROUTES } from '../constants/api-routes';
@Injectable({
  providedIn: 'root'
})
export class AuthService {
  isLoging: boolean = false;

  constructor(private http: HttpClientHelper) { }

  login(email: string, password: string): boolean {
    this.http.postAsync<boolean>(API_ROUTES.VERIFICATION, { email: email, password: password })
      .subscribe(result => {
        this.isLoging = result;
      });

    return this.isLoging;
  }

  logout(): void {
    this.isLoging = false;
  }
}
