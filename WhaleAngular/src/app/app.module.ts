import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FarmersMarketComponent } from './farmers-market/farmers-market.component';
import { LoginScreenComponent } from './login-screen/login-screen.component';
import { RanchViewComponent } from './ranch-view/ranch-view.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { PaddockViewComponent } from './paddock-view/paddock-view.component';
import { AdminComponent } from './admin/admin.component';
import { NavbarComponent } from './navbar/navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    FarmersMarketComponent,
    LoginScreenComponent,
    RanchViewComponent,
    DashboardComponent,
    PaddockViewComponent,
    AdminComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
