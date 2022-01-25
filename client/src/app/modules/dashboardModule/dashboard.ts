import { Component, OnInit } from '@angular/core';
import { Produs } from 'src/app/models/produs';
import { ProdusService } from 'src/app/services/produs.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.html'
})
export class DashboardComponent implements OnInit {

  public products: Produs[] = [];

  constructor(private _produsService: ProdusService) { }

  ngOnInit(): void {
    this.getProducts();
  }

  getProducts(){
    this._produsService.getAllProducts().subscribe((items: Produs[])=> {
      this.products = items;
    })
  }
}