import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FarmersMarketComponent } from './farmers-market/farmers-market.component';
import { LoginScreenComponent } from './login-screen/login-screen.component';
import { PaddockViewComponent } from './paddock-view/paddock-view.component';
import { RanchViewComponent } from './ranch-view/ranch-view.component';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'admin', component: AdminComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'farmer', component: FarmersMarketComponent },
  { path: 'login', component: LoginScreenComponent },
  { path: 'paddock', component: PaddockViewComponent },
  { path: 'ranch', component: RanchViewComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
