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
import { MyTestsPageComponent } from './pages/my-tests-page/my-tests-page.component';
import { CreateNewTestPageComponent } from './pages/create-new-test-page/create-new-test-page.component';
import { RecommendedTestsPageComponent } from './pages/recommended-tests-page/recommended-tests-page.component';
import { StarredTestsComponent } from './pages/starred-tests/starred-tests.component';
import { MenuComponent } from './components/menu/menu.component';

const appRoutes: Routes = [
    {
    path: '',
    component: DashboardPageComponent
  },
  {
    path: 'login',
    component: LoginPageComponent
  },
  {
    path: 'myTests',
    component: MyTestsPageComponent
  },
  {
    path: 'createTest',
    component: CreateNewTestPageComponent
  },
  {
    path: 'recommendedTests',
    component: RecommendedTestsPageComponent
  },
  {
    path: 'starredTests',
    component: StarredTestsComponent
  },
];

@NgModule({
  declarations: [
    AppComponent,
    LoginPageComponent,
    HeaderComponent,
    FooterComponent,
    LoginFormComponent,
    DashboardPageComponent,
    MyTestsPageComponent,
    CreateNewTestPageComponent,
    RecommendedTestsPageComponent,
    StarredTestsComponent,
    MenuComponent
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
