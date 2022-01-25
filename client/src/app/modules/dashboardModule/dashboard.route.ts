import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddProdusComponent } from './addprodus/addprodus';
import { DashboardComponent } from './dashboard';

const routes: Routes = [
    {path: '', component: DashboardComponent},
    { path: 'addprodus',component: AddProdusComponent }
];

@NgModule({
imports: [
    RouterModule.forChild(routes)
    ],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }