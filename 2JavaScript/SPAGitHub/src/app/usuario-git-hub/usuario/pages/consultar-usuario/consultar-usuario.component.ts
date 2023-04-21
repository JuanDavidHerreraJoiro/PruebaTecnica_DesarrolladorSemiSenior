import { Component,OnInit  } from '@angular/core';
import { Usuario } from '../../classes/usuario';
import { UsuarioService } from '../../services/usuario.service';
import Swal from 'sweetalert2';
import { catchError } from 'rxjs';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-consultar-usuario',
  templateUrl: './consultar-usuario.component.html',
  styleUrls: ['./consultar-usuario.component.css']
})
export class ConsultarUsuarioComponent implements OnInit {

  usuario?: Usuario ;
  input: string = 'Nombre de usuario';

  constructor(private usuarioService:UsuarioService) {
    
  }

  ngOnInit(): void {
    //this.consultarUsuario(this.input);
  }

  onClick() {
    this.consultarUsuario(this.input);
  }

  consultarUsuario(user:string){
    if (user.trim() === '') {
      this.usuario = undefined;
      this.messageDialog();
    } else {
      this.usuarioService.getUsuario(user.trim())
      .subscribe(
        (usuario) => {
          this.usuario = usuario;
            console.log(this.usuarioService);
        },
        (error) => {
          console.log('HTTP request status:', error.status);
          if (error.status == undefined || error.status >= 400) {
            this.usuario = undefined;
            this.messageDialog();
          }
        }
      ); 
    }
  }

  messageDialog(){
    Swal.fire({
      icon: 'error',
      title: 'Oops...',
      text: 'No hay usuarios que cumplan con el criterio de búsqueda!'
    })
  }

}