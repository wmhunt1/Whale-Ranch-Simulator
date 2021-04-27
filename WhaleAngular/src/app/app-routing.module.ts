import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './pages/admin/admin.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { FarmersMarketComponent } from './pages/farmers-market/farmers-market.component';
import { LoginScreenComponent } from './pages/login-screen/login-screen.component';
import { PaddockViewComponent } from './pages/paddock-view/paddock-view.component';
import { RanchViewComponent } from './pages/ranch-view/ranch-view.component';
import { StartRanchComponent } from './pages/start-ranch/start-ranch.component';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'admin', component: AdminComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'farmer', component: FarmersMarketComponent },
  { path: 'login', component: LoginScreenComponent },
  { path: 'paddock', component: PaddockViewComponent },
  { path: 'ranch', component: RanchViewComponent },
  { path: 'start', component: StartRanchComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
