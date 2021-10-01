import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CadastrarMotoristaComponent } from './components/views/motorista/cadastrar-motorista/cadastrar-motorista.component';
import { FormsModule } from '@angular/forms';
import { ListarMotoristaComponent } from './components/views/motorista/listar-motorista/listar-motorista.component';
import { DeletarMotoristaComponent } from './components/views/motorista/deletar-motorista/deletar-motorista.component';
import { AlterarMotoristaComponent } from './components/views/motorista/alterar-motorista/alterar-motorista.component';
import { CadastrarVeiculoComponent } from './components/views/veiculo/cadastrar-veiculo/cadastrar-veiculo.component';
import { ListarVeiculoComponent } from './components/views/veiculo/listar-veiculo/listar-veiculo.component';
import { AlterarVeiculoComponent } from './components/views/veiculo/alterar-veiculo/alterar-veiculo.component';
import { DeletarVeiculoComponent } from './components/views/veiculo/deletar-veiculo/deletar-veiculo.component';
import { MenuProjetoComponent } from './components/views/menu/menu-projeto/menu-projeto.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuProjetoComponent,
    CadastrarMotoristaComponent,
    ListarMotoristaComponent,
    DeletarMotoristaComponent,
    AlterarMotoristaComponent,
    CadastrarVeiculoComponent,
    ListarVeiculoComponent,
    AlterarVeiculoComponent,
    DeletarVeiculoComponent,
 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
