import { Component } from '@angular/core';
import { Cliente } from 'src/shared/models/cliente.model';
import { LoginService } from 'src/services/login.service';
import { Router } from '@angular/router';
import { AuthenticateModel} from 'src/shared/models/request/auth.model';
import { ResponseModelWithResult } from 'src/shared/models/response/response-model';

@Component({
       selector: "cadastro",
       templateUrl: "cadastro.component.html"
})
export class CadastroComponent {

              constructor(private _loginService:LoginService, private router: Router) {}



              onSubscribe(cliente:Cliente) {

                     let authModel = new  AuthenticateModel();

                     authModel.UserName = cliente.DsCpfCnpj;
                     authModel.Password = cliente.DsSenha;

                     this._loginService.Auth(authModel).subscribe((response : ResponseModelWithResult<Cliente>) => {

                            this._loginService.setToken(response._result.Token.toString())
                            
                            this.onLogin();

                     });

              }

              onLogin() {
                     this.router.navigate(["/"]);
              }

}