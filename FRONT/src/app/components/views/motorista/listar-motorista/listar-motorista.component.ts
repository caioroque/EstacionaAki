import { MotoristaService } from './../../../../services/motorista.service';
import { Motorista } from './../../../../models/motorista';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-listar-motorista',
  templateUrl: './listar-motorista.component.html',
  styleUrls: ['./listar-motorista.component.css']
})
export class ListarMotoristaComponent implements OnInit {
  motoristas: Motorista[] = [];
  constructor(private service: MotoristaService) { }

  ngOnInit(): void {
    this.service.list().subscribe((motoristas) => {
      this.motoristas = motoristas;
      for (let motorista of motoristas){
        console.log(motorista);
      }
    })
  }

}
