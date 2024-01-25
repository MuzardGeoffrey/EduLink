import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })

export class HttpClientHelper {
  constructor(private httpClient: HttpClient) {
    this.httpClient = httpClient;
  }

  public getAsync<T>(url: string): Observable<T> {
    return this.httpClient.get<T>(url);
  }

  public postAsync<T>(url: string, data: any): Observable<T> {
    return this.httpClient.post<T>(url, data);
  }
}
