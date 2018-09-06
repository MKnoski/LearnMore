import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { LoginPageComponent } from './pages/login-page/login-page.component';
import { HeaderComponent } from './components/global/header/header.component';
import { FooterComponent } from './components/global/footer/footer.component';
import { LoginFormComponent } from './components/login/login-form/login-form.component';
import { DashboardPageComponent } from './pages/dashboard-page/dashboard-page.component';
import { MyTestsPageComponent } from './pages/my-tests-page/my-tests-page.component';
import { CreateTestPageComponent } from './pages/create-test-page/create-test-page.component';
import { RecommendedTestsPageComponent } from './pages/recommended-tests-page/recommended-tests-page.component';
import { StarredTestsComponent } from './pages/starred-tests/starred-tests.component';
import { MenuComponent } from './components/global/menu/menu.component';
import { CreateTestFormComponent } from './components/create-test/create-test-form/create-test-form.component';
import { NewQuestionComponent } from './components/create-test/new-question/new-question.component';
import { NewAnswerComponent } from './components/create-test/new-answer/new-answer.component';

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
    component: CreateTestPageComponent
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
    CreateTestPageComponent,
    RecommendedTestsPageComponent,
    StarredTestsComponent,
    MenuComponent,
    CreateTestFormComponent,
    NewQuestionComponent,
    NewAnswerComponent
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
