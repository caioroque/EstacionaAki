import { Veiculo } from './../models/veiculo';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class VeiculoService {
  private baseURL = "http://localhost:5000/ESTACIONAAKI/veiculo";

  constructor(private http: HttpClient) {}

  list(): Observable<Veiculo[]> {return this.http.get<Veiculo[]>(`${this.baseURL}/list`);}

  create(veiculo: Veiculo): Observable<Veiculo> {return this.http.post<Veiculo>(`${this.baseURL}/create`, veiculo);}

  delete(placa: string): Observable<void> {return this.http.delete<void>(`${this.baseURL}/delete`+'/'+placa);}

  update(veiculo: Veiculo): Observable<any> {return this.http.put(`${this.baseURL}/update`, veiculo);}
}