import { Veiculo } from './../../../../models/veiculo';
import { VeiculoService } from './../../../../services/veiculo.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastrar-veiculo',
  templateUrl: './cadastrar-veiculo.component.html',
  styleUrls: ['./cadastrar-veiculo.component.css']
})
export class CadastrarVeiculoComponent implements OnInit {
  placa!: string;
  cor!: string;

  constructor(private service: VeiculoService, private router: Router) {}

  ngOnInit(): void {}

  cadastrar(): void {
  let veiculo: Veiculo = {
      placa: this.placa,
      cor: this.cor,
    };
    this.service.create(veiculo).subscribe((veiculo) => {
      console.log(veiculo);
      this.router.navigate(["veiculo/listar"])
    });
  }
}
