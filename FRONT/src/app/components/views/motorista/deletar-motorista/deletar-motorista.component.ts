import { Observable } from 'rxjs';
import { Motorista } from './../../../../models/motorista';
//import { DeletarVeiculoComponent } from './../../veiculo/deletar-veiculo/deletar-veiculo.component';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MotoristaService } from 'src/app/services/motorista.service';

@Component({
  selector: 'app-deletar-motorista',
  templateUrl: './deletar-motorista.component.html',
  styleUrls: ['./deletar-motorista.component.css']
})
export class DeletarMotoristaComponent implements OnInit {
  nomeMotorista!: string;

  constructor(private service: MotoristaService, private router: Router) { }

  ngOnInit(): void {}

  deletar() {
     this.service.delete(this.nomeMotorista).subscribe(() => {
     console.log(`${this.nomeMotorista} Deletado`);
     this.router.navigate(["motorista/listar"])
  });
  }
}

