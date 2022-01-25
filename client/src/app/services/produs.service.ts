import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Produs } from "../models/produs";

@Injectable()
export class ProdusService {
  baseUrl = 'https://localhost:44308/api/produs';
  constructor(private http: HttpClient) {
    }

   getAllProducts(): Observable<Produs[]> {
    return this.http.get<Produs[]>(this.baseUrl)
  }

  deleteProduct(id: number): Observable<any>{
    return this.http.delete<any>(this.baseUrl+"/"+id);
  }

  getProduct(id: number): Observable<Produs>{
    return this.http.get<Produs>(this.baseUrl+"/"+id);
  }

  createProduct(model: Produs): Observable<any>{
    return this.http.post<Produs>(this.baseUrl,model);
  }

}