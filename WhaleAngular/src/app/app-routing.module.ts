import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminPageComponent } from './components/pages/admin-page/admin-page.component';
import { LoginPageComponent } from './components/pages/login-page/login-page.component';
import { MainPageComponent } from './components/pages/main-page/main-page.component';

const routes: Routes = [
  {path: '', component: LoginPageComponent},
  {path: 'admin', component: AdminPageComponent},
  {path: 'main', component: MainPageComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
