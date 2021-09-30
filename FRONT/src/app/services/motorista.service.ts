import { HttpClient } from "@angular/common/http";
import { Motorista } from './../models/motorista';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MotoristaService {
  private baseURL = "http://localhost:5000/ESTACIONAAKI/motorista";

  constructor(private http: HttpClient) {}

  list(): Observable<Motorista[]> {return this.http.get<Motorista[]>(`${this.baseURL}/list`);}

  create(motorista: Motorista): Observable<Motorista> {return this.http.post<Motorista>(`${this.baseURL}/create`, motorista);}

  delete(nomeMotorista: string): Observable<void> {return this.http.delete<void>(`${this.baseURL}/delete`+'/'+nomeMotorista);}

  update(motorista: Motorista): Observable<any> {return this.http.put(`${this.baseURL}/update`, motorista);}

}
