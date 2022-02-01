import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { User } from "../models/user";

@Injectable()
export class UserService {
  baseUrl = 'https://localhost:44308/api/user';
  constructor(private http: HttpClient) {
    }

   getAllUsers(): Observable<User[]> {
    return this.http.get<User[]>(this.baseUrl)
  }

  deleteUser(id: number): Observable<any>{
    return this.http.delete<any>(this.baseUrl+"/"+id);
  }

  getUser(id: number): Observable<User>{
    return this.http.get<User>(this.baseUrl+"/"+id);
  }

  createUser(model: User): Observable<any>{
    return this.http.post<User>(this.baseUrl,model);
  }

}