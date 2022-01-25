import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { DashboardComponent } from './dashboard';
import { DashboardRoutingModule } from './dashboard.route';
import { TableModule } from 'primeng/table';
import { ProdusService } from 'src/app/services/produs.service';


@NgModule({
  declarations: [
    DashboardComponent
  ],
  imports: [
    DashboardRoutingModule,
    TableModule
  ],
  providers: [ProdusService]
})
export class DashboardModule { }