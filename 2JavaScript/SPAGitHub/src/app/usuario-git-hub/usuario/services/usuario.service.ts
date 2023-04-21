import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, map, Observable, of, Subject, tap, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Usuario } from '../classes/usuario';


@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  baseUrl: string;
  private _refrescar$ = new Subject<void>();

  constructor(
    private http: HttpClient
  ) {
    this.baseUrl = environment.baseUrl;
  }

  get refrescar$(){
    return this._refrescar$;
  }

  getUsuario(user:string):Observable<Usuario>{
    return this.http.get<Usuario>(`${this.baseUrl}/users/${user}`)
    .pipe(
      catchError(this.handleError)
    );
  }

  private handleError(error: HttpErrorResponse) {

    if (error.error.message == "Not Found"){
      console.error('Error:', error.error.message);
    }else if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong.
      console.error(
        `Consulta Usuario ${error.message}, ` +
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    // Return an observable with a user-facing error message.
    return throwError(error.status);
  };
}