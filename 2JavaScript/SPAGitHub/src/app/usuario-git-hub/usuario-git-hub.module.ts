import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from '../design-modules/material.module';
import { ConsultarUsuarioComponent } from './usuario/pages/consultar-usuario/consultar-usuario.component';
import { UsuarioRoutingModule } from './usuario-routing.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    ConsultarUsuarioComponent,
  ],
  imports: [
    CommonModule,
    MaterialModule,
    FlexLayoutModule,
    UsuarioRoutingModule,
    FormsModule,
        
  ]
})
export class UsuarioGitHubModule { }
