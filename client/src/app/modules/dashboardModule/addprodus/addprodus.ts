
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { InputTextModule } from 'primeng/inputtext';

import { ProdusService } from 'src/app/services/produs.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Produs } from 'src/app/models/produs';

@Component({
  selector: 'app-addprodus',
  templateUrl: './addprodus.html',
  encapsulation: ViewEncapsulation.None
})

export class AddProdusComponent implements OnInit {
    entity: Produs = new Produs();        

  constructor(
    private _produsService: ProdusService,
    private router: Router) { 
    }

  ngOnInit() {
  }
  
  add(){
   this._produsService.createProduct(this.entity).subscribe();   
   this.router.navigate(['dashboard']);
  }
}
