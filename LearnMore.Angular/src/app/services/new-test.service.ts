import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Test } from '../models/create-test/test';

@Injectable()
export class NewTestService {

  private readonly httpClient: HttpClient;

  constructor(httpClient: HttpClient) {
    this.httpClient = httpClient;
  }

  public SaveNewTest(newTest: Test): boolean {

    const httpOptions = {
      headers: new HttpHeaders({
        ContentType:  'application/json',
        Authorization: 'my-auth-token'
      })};

    this.httpClient
      .post<boolean>('/api/Test', newTest, httpOptions)
      .subscribe(isSuccess => {
        console.log(isSuccess);
    });

    return true;
  }
}
