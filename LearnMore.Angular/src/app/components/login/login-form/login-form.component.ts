import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../../../services/authentication.service';
import { Login } from '../../../models/authentication/login';

@Component({
  selector: 'lm-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css'],
  providers: [AuthenticationService]
})
export class LoginFormComponent implements OnInit {

  public login: Login = new Login();
  public authenticationService: AuthenticationService;

  constructor(authenticationService: AuthenticationService) {
      this.authenticationService = authenticationService;
  }

  public ngOnInit(): void {
  }

  public loginUser(event: Event): void {
    event.preventDefault();

    this.authenticationService.login(this.login);

    console.log(this.login.email + ' ' + this.login.password);
  }

}
