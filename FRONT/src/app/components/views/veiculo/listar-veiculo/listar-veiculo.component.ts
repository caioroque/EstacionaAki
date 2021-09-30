import { VeiculoService } from './../../../../services/veiculo.service';
import { Veiculo } from './../../../../models/veiculo';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-listar-veiculo',
  templateUrl: './listar-veiculo.component.html',
  styleUrls: ['./listar-veiculo.component.css']
})
export class ListarVeiculoComponent implements OnInit {
  veiculos: Veiculo[] = [];
  constructor(private service: VeiculoService) { }

  ngOnInit(): void {
    this.service.list().subscribe((veiculos) => {
      this.veiculos = veiculos;
      for (let veiculo of veiculos){
        console.log(veiculo);
      }
    })
  }

}
