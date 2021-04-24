import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginPageComponent } from './pages/login-page/login-page.component';
import { AdminPageComponent } from './pages/admin-page/admin-page.component';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import { MainPageComponent } from './pages/main-page/main-page.component';
import { FormsModule } from '@angular/forms';
import { WhaleDetailComponent } from './components/whale-detail/whale-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginPageComponent,
    AdminPageComponent,
    NavBarComponent,
    MainPageComponent,
    WhaleDetailComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
