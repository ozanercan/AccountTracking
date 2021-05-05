import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from './pages/login-page/login-page.component';
import { UserMainPageComponent } from './pages/user-main-page/user-main-page.component';

const routes: Routes = [
  { path: 'login', component: LoginPageComponent },
  { path: 'user/home', component: UserMainPageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
