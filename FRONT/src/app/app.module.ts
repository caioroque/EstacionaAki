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

@NgModule({
  declarations: [
    AppComponent,
    CadastrarMotoristaComponent,
    ListarMotoristaComponent,
    DeletarMotoristaComponent,
    AlterarMotoristaComponent,
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
