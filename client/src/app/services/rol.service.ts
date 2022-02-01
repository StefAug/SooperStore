import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Rol } from "../models/rol";

@Injectable()
export class RolService {
  baseUrl = 'https://localhost:44308/api/rol';
  constructor(private http: HttpClient) {
    }

   getAllRols(): Observable<Rol[]> {
    return this.http.get<Rol[]>(this.baseUrl)
  }

  deleteRol(id: number): Observable<any>{
    return this.http.delete<any>(this.baseUrl+"/"+id);
  }

  getRol(id: number): Observable<Rol>{
    return this.http.get<Rol>(this.baseUrl+"/"+id);
  }

  createRol(model: Rol): Observable<any>{
    return this.http.post<Rol>(this.baseUrl,model);
  }

}