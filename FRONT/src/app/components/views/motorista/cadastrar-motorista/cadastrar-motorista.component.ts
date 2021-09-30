import { Motorista } from './../../../../models/motorista';
import { MotoristaService } from './../../../../services/motorista.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastrar-motorista',
  templateUrl: './cadastrar-motorista.component.html',
  styleUrls: ['./cadastrar-motorista.component.css']
})
export class CadastrarMotoristaComponent implements OnInit {
  nomeMotorista!: string;
  cpf!: string;
  telefone!: string;

  constructor(private service: MotoristaService, private router: Router) {}

  ngOnInit(): void {}

  cadastrar(): void {
  let motorista: Motorista = {
      nomeMotorista: this.nomeMotorista,
      cpf: this.cpf,
      telefone: this.telefone,
    };
    this.service.create(motorista).subscribe((motorista) => {
      console.log(motorista);
      this.router.navigate(["motorista/listar"])
    });
  }
}
