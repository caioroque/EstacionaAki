import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Motorista } from 'src/app/models/motorista';
import { MotoristaService } from 'src/app/services/motorista.service';

@Component({
  selector: 'app-alterar-motorista',
  templateUrl: './alterar-motorista.component.html',
  styleUrls: ['./alterar-motorista.component.css']
})
export class AlterarMotoristaComponent implements OnInit {
  id!: number;
  nomeMotorista!: string;
  cpf!: string;
  telefone!: string;
  constructor(private service: MotoristaService, private router: Router) { }

  ngOnInit(): void {
  }

  alterar(): void{
    let motorista: Motorista = {
      id: this.id,
      nomeMotorista: this.nomeMotorista,
      cpf: this.cpf,
      telefone: this.telefone,
    };
    if(motorista.id == this.id){
      this.service.update(motorista).subscribe((motorista) => {
      console.log(motorista);
      this.router.navigate(["motorista/listar"])
    });
  }
  }
}