import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { VeiculoComponent } from './components/views/veiculo/veiculo.component';
import { CadastrarVeiculoComponent } from './components/views/veiculo/cadastrar-veiculo/cadastrar-veiculo.component';

@NgModule({
  declarations: [
    AppComponent,
    VeiculoComponent,
    CadastrarVeiculoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
