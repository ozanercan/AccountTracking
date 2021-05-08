import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ManagementComponent } from './components/management/management.component';
import { LoginGuard } from './guards/login.guard';
import { LoginPageComponent } from './pages/login-page/login-page.component';
import { ManagementMainPageComponent } from './pages/management-main-page/management-main-page.component';
import { UserCreatePageComponent } from './pages/user-create-page/user-create-page.component';

const routes: Routes = [
  { path: 'login', component: LoginPageComponent },
  {
    path: 'management',
    component: ManagementComponent,
    canActivate: [LoginGuard],
    children: [
      {
        path: 'home',
        component: ManagementMainPageComponent,
      },
      {
        path: 'user/create',
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
