import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginPageComponent } from './pages/login-page/login-page.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { ManagementMainPageComponent } from './pages/management-main-page/management-main-page.component';
import { FeatureCardComponent } from './components/feature-card/feature-card.component';
import { UserCreatePageComponent } from './pages/user-create-page/user-create-page.component';
import { UrlIncluderInterceptor } from './interceptors/url-includer.interceptor';
import { AuthorizationIncluderInterceptor } from './interceptors/authorization-includer.interceptor';
import { LoginGuard } from './guards/login.guard';
import { UserLoginComponent } from './components/user-login/user-login.component';
import { ManagementComponent } from './components/management/management.component';
import { UserCreateComponent } from './components/user-create/user-create.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginPageComponent,
    SidebarComponent,
    FeatureCardComponent,
    UserCreatePageComponent,
    UserLoginComponent,
    ManagementComponent,
    ManagementMainPageComponent,
    UserCreateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    CommonModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    ReactiveFormsModule,
    FormsModule,
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: UrlIncluderInterceptor,
      multi: true,
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthorizationIncluderInterceptor,
      multi: true,
    },
    LoginGuard
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
