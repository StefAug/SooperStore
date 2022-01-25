import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { DashboardComponent } from './dashboard';
import { DashboardRoutingModule } from './dashboard.route';


@NgModule({
  declarations: [
    DashboardComponent
  ],
  imports: [
    DashboardRoutingModule
  ],
  providers: []
})
export class DashboardModule { }