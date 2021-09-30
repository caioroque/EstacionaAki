import { VeiculoService } from './../../../../services/veiculo.service';
import { Veiculo } from './../../../../models/veiculo';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-deletar-veiculo',
  templateUrl: './deletar-veiculo.component.html',
  styleUrls: ['./deletar-veiculo.component.css']
})
export class DeletarVeiculoComponent implements OnInit {
  placa!: string;

  constructor(private service: VeiculoService, private router: Router) { }

  ngOnInit(): void {}

  deletar() {
     this.service.delete(this.placa).subscribe(() => {
     console.log(`${this.placa} Deletado`);
     this.router.navigate(["veiculo/listar"])
  });
  }
}

