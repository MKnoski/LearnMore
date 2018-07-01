import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../../services/authentication.service';
import { Login } from '../../models/login';

@Component({
  selector: 'lm-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css'],
  providers: [AuthenticationService]
})
export class LoginFormComponent implements OnInit {

  login = new Login();
  authenticationService: AuthenticationService;

  constructor(authenticationService: AuthenticationService) {
      this.authenticationService = authenticationService;
  }

  ngOnInit() {
  }

  loginUser(event) {
    event.preventDefault();

    this.authenticationService.login();

    console.log(this.login.email + ' ' + this.login.password);
  }

}
