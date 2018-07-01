import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { LoginPageComponent } from './pages/login-page/login-page.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { LoginFormComponent } from './components/login-form/login-form.component';
import { DashboardPageComponent } from './pages/dashboard-page/dashboard-page.component';

const appRoutes: Routes = [
  {
    path: '',
    component: LoginPageComponent
  },
  {
    path: 'home',
    component: DashboardPageComponent
  },
];

@NgModule({
  declarations: [
    AppComponent,
    LoginPageComponent,
    HeaderComponent,
    FooterComponent,
    LoginFormComponent,
    DashboardPageComponent
  ],
  imports: [
    RouterModule.forRoot(appRoutes),
    BrowserModule,
    FormsModule,
    NgbModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
