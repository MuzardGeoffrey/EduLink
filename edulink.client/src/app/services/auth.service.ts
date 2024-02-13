import { Injectable } from '@angular/core';
import { HttpClientHelper } from './HttpClientHelper.service';
import { API_ROUTES } from '../constants/api-routes';
import { Observable, Subscriber, catchError, of, tap } from 'rxjs';
import { HttpErrorResponse } from '@angular/common/http';
import { User } from '../models/User';
@Injectable({
  providedIn: 'root'
})
export class AuthService {
  isLoging: boolean = false;
  userId: number = 0;
  constructor(private http: HttpClientHelper) { }

  public login(email: string, password: string): Observable<number> {
    return this.http.postAsync<number>(API_ROUTES.VERIFICATION, { email: email, password: password }).pipe(
      tap((result: number) => {
        if (result > 0) {
          this.isLoging = true;
          this.userId = result;
        }
      }),
      catchError((error: HttpErrorResponse) => {
        if (error.status != 401) {
          console.log(error);
        };
        return of(0);
      }
      )
    );
  }

  public logout(): void {
    this.isLoging = false;
  }
}
