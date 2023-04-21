import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConsultarUsuarioComponent } from './usuario/pages/consultar-usuario/consultar-usuario.component';

const routes: Routes = [
  {
    path: 'consultar-usuario',
    component: ConsultarUsuarioComponent,
  },
  {
    path: '**',
    redirectTo: 'consultar-usuario'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UsuarioRoutingModule { }
