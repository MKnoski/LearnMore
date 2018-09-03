import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Login } from '../models/authentication/login';
import { Token } from '../models/authentication/token';

@Injectable()
export class AuthenticationService {
  httpClient: HttpClient;

  constructor(httpClient: HttpClient) {
    this.httpClient = httpClient;
  }

  login(login: Login): boolean {

    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        'Authorization': 'my-auth-token'
      })};

    this.httpClient
      .post<Token>('/api/Authentication/login', login, httpOptions)
      .subscribe(token => {
        console.log(token.authToken);
    });

    return true;
  }

}
