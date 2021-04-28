import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FarmersMarketComponent } from './pages/farmers-market/farmers-market.component';
import { LoginScreenComponent } from './pages/login-screen/login-screen.component';
import { RanchViewComponent } from './pages/ranch-view/ranch-view.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { PaddockViewComponent } from './pages/paddock-view/paddock-view.component';
import { AdminComponent } from './pages/admin/admin.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { FooterComponent } from './shared/footer/footer.component';
import { LogoComponent } from './components/logo/logo.component';
import { StartRanchComponent } from './pages/start-ranch/start-ranch.component';
import { WhaleDetailComponent } from './components/whale-detail/whale-detail.component';
import { WhalesComponent } from './components/whales/whales.component';

@NgModule({
  declarations: [
    AppComponent,
    FarmersMarketComponent,
    LoginScreenComponent,
    RanchViewComponent,
    DashboardComponent,
    PaddockViewComponent,
    AdminComponent,
    NavbarComponent,
    FooterComponent,
    LogoComponent,
    StartRanchComponent,
    WhaleDetailComponent,
    WhalesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
