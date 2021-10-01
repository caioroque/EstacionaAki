import { MenuProjetoComponent } from './components/views/menu/menu-projeto/menu-projeto.component';
import { DeletarVeiculoComponent } from './components/views/veiculo/deletar-veiculo/deletar-veiculo.component';
import { AlterarVeiculoComponent } from './components/views/veiculo/alterar-veiculo/alterar-veiculo.component';
import { ListarVeiculoComponent } from './components/views/veiculo/listar-veiculo/listar-veiculo.component';
import { CadastrarVeiculoComponent } from './components/views/veiculo/cadastrar-veiculo/cadastrar-veiculo.component';
import { AlterarMotoristaComponent } from './components/views/motorista/alterar-motorista/alterar-motorista.component';
import { DeletarMotoristaComponent } from './components/views/motorista/deletar-motorista/deletar-motorista.component';
import { ListarMotoristaComponent } from './components/views/motorista/listar-motorista/listar-motorista.component';
import { CadastrarMotoristaComponent } from './components/views/motorista/cadastrar-motorista/cadastrar-motorista.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path:"veiculo/deletar",
    component: DeletarVeiculoComponent,
  },
  {
    path:"veiculo/alterar",
    component: AlterarVeiculoComponent,
  },
  {
    path:"veiculo/listar",
    component: ListarVeiculoComponent,
  },
  {
    path:"veiculo/cadastrar",
    component: CadastrarVeiculoComponent,
  },
  {
    path:"motorista/alterar",
    component: AlterarMotoristaComponent,
  },
  {
    path:"motorista/deletar",
    component: DeletarMotoristaComponent,
  },
  {
    path:"",
    component: ListarMotoristaComponent,
  },
  {
    path:"motorista/listar",
    component: ListarMotoristaComponent,
  },
  {
    path:"motorista/cadastrar",
    component: CadastrarMotoristaComponent,
  },
  {
    path:"",
    component: MenuProjetoComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
