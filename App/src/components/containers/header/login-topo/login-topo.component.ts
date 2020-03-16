import { Component, OnInit } from '@angular/core';
import { Cliente } from 'src/shared/models/cliente.model';
import {LoginAreaEmitterService} from 'src/services/emitters/login-area-emitter.service';
import { LoginService } from 'src/services/login.service';
import { ResponseModelWithResult } from 'src/shared/models/response/response-model';
import { ClienteService } from 'src/services/cliente.service';

@Component({
    selector: "login-topo",
    templateUrl: "login-topo.component.html"
})
export class LoginTopoComponent implements OnInit {

        Cliente: Cliente;


        constructor(private _clienteService:ClienteService) {

        }

        ngOnInit() {

            this._clienteService.GetCurrent().subscribe((response : ResponseModelWithResult<Cliente> ) => {
                    this.Cliente = response._result;
            }, err => {

                this.Cliente = null;

            });
        }

}