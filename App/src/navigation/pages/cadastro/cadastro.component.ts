import { Component, OnInit } from '@angular/core';
import { Cliente } from 'src/shared/models/cliente.model';
import { LoginService } from 'src/services/login.service';
import { Router } from '@angular/router';
import { AuthenticateModel} from 'src/shared/models/request/auth.model';
import { ResponseModelWithResult } from 'src/shared/models/response/response-model';
import { ContextService } from 'src/services/storage/context.service';
import { ClienteService } from 'src/services/cliente.service';

@Component({
       selector: "cadastro",
       templateUrl: "cadastro.component.html"
})
export class CadastroComponent implements OnInit {

              constructor(private _loginService:LoginService, private router: Router) {}

              onSubscribe(cliente:Cliente) {

                     this._loginService.Auth({

                            UserName : cliente.DsCpfCnpj,
                           Password : cliente.DsSenha

                     }).subscribe((response : ResponseModelWithResult<Cliente>) => {
                     
                            ContextService.setToken(response._result.Token.toString());
                            this.onLogin();
                     });

              }

              onLogin() {
                     this._loginService.decodeAndNotify();
                     this.router.navigate(["/"]);
              }

              ngOnInit() {
                     if(ContextService.isLoggedIn)
                     this.onLogin();
              }

}