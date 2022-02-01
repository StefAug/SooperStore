import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Comanda } from "../models/comanda";

@Injectable()
export class ComandaService {
  baseUrl = 'https://localhost:44308/api/comanda';
  constructor(private http: HttpClient) {
    }

   getAllComands(): Observable<Comanda[]> {
    return this.http.get<Comanda[]>(this.baseUrl)
  }

  deleteComand(id: number): Observable<any>{
    return this.http.delete<any>(this.baseUrl+"/"+id);
  }

  getComand(id: number): Observable<Comanda>{
    return this.http.get<Comanda>(this.baseUrl+"/"+id);
  }

  createComand(model: Comanda): Observable<any>{
    return this.http.post<Comanda>(this.baseUrl,model);
  }

}