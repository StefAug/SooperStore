import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Cos } from "../models/cos";

@Injectable()
export class ColsService {
  baseUrl = 'https://localhost:44308/api/cos';
  constructor(private http: HttpClient) {
    }

   getAllCos(): Observable<Cos[]> {
    return this.http.get<Cos[]>(this.baseUrl)
  }

  deleteCos(id: number): Observable<any>{
    return this.http.delete<any>(this.baseUrl+"/"+id);
  }

  getCos(id: number): Observable<Cos>{
    return this.http.get<Cos>(this.baseUrl+"/"+id);
  }

  createCos(model: Cos): Observable<any>{
    return this.http.post<Cos>(this.baseUrl,model);
  }

}