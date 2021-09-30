import { Veiculo } from './../../../../models/veiculo';
import { VeiculoService } from './../../../../services/veiculo.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-alterar-veiculo',
  templateUrl: './alterar-veiculo.component.html',
  styleUrls: ['./alterar-veiculo.component.css']
})
export class AlterarVeiculoComponent implements OnInit {
  id!: number;
  placa!: string;
  cor!: string;
  constructor(private service: VeiculoService, private router: Router) { }

  ngOnInit(): void {
  }

  alterar(): void{
    let veiculo: Veiculo = {
      id: this.id,
      placa: this.placa,
      cor: this.cor,
    };
    if(veiculo.id == this.id){
      this.service.update(veiculo).subscribe((veiculo) => {
      console.log(veiculo);
      this.router.navigate(["veiculo/listar"])
    });
  }
  }
}