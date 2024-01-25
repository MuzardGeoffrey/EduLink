import { Injectable } from '@angular/core';
import { HttpClientHelper } from './HttpClientHelper.service';
import { API_ROUTES } from '../constants/api-routes';
import { Observable, tap } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class AuthService {
  isLoging: boolean = false;

  constructor(private http: HttpClientHelper) { }

  public login(email: string, password: string): Observable<boolean> {
    return this.http.postAsync<boolean>(API_ROUTES.VERIFICATION, { email: email, password: password })
      .pipe(
        tap((result: boolean) => {
          this.isLoging = result;
        })
      );
  }

  public logout(): void {
    this.isLoging = false;
  }
}
