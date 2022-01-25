import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { DashboardComponent } from './modules/dashboardModule/dashboard';
import { DashboardModule } from './modules/dashboardModule/dashboard.module';
import { MainPageComponent } from './modules/mainpage/mainpage';

const routes: Routes = [
{
  path: 'dashboard',
  loadChildren: () => DashboardModule
},
{
  path: '',
  component: MainPageComponent,
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
