import { AlterarMotoristaComponent } from './components/views/motorista/alterar-motorista/alterar-motorista.component';
import { DeletarMotoristaComponent } from './components/views/motorista/deletar-motorista/deletar-motorista.component';
import { ListarMotoristaComponent } from './components/views/motorista/listar-motorista/listar-motorista.component';
import { CadastrarMotoristaComponent } from './components/views/motorista/cadastrar-motorista/cadastrar-motorista.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
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
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
