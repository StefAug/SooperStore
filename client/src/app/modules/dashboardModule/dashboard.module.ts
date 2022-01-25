import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { DashboardComponent } from './dashboard';
import { DashboardRoutingModule } from './dashboard.route';
import { TableModule } from 'primeng/table';
import { ProdusService } from 'src/app/services/produs.service';
import { FormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { AddProdusComponent } from './addprodus/addprodus';


@NgModule({
  declarations: [
    DashboardComponent,
    AddProdusComponent
  ],
  imports: [
    DashboardRoutingModule,
    TableModule,
    FormsModule,
    ButtonModule
  ],
  providers: [ProdusService]
})
export class DashboardModule { }