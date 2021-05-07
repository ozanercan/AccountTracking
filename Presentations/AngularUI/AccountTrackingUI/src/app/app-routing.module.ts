import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserComponent } from './components/user/user.component';
import { LoginGuard } from './guards/login.guard';
import { LoginPageComponent } from './pages/login-page/login-page.component';
import { UserCreatePageComponent } from './pages/user-create-page/user-create-page.component';
import { UserMainPageComponent } from './pages/user-main-page/user-main-page.component';

const routes: Routes = [
  { path: 'login', component: LoginPageComponent },
  {
    path: 'user',
    component: UserComponent,
    canActivate: [LoginGuard],
    children: [
      {
        path: 'home',
        component: UserMainPageComponent,
      },
      {
        path: 'create',
        component: UserCreatePageComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
