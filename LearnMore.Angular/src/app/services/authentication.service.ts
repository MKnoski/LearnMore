import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class AuthenticationService {
  httpClient: HttpClient;

  constructor(httpClient: HttpClient) {
    this.httpClient = httpClient;
  }

  login(): boolean {

    // this.httpClient.get<myData>('http://localhost:50000/api/values').

    this.httpClient.get('/api/values').subscribe(data => {
      console.log(data);
    });

    return true;
  }

}
