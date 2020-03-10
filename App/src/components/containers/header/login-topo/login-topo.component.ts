import { Component, OnInit } from '@angular/core';
import { Cliente } from 'src/shared/models/cliente.model';
import {LoginAreaEmitterService} from 'src/services/emitters/login-area-emitter.service';

@Component({
    selector: "login-topo",
    templateUrl: "login-topo.component.html"
})
export class LoginTopoComponent implements OnInit {


        Cliente: Cliente;

        ngOnInit() {

            LoginAreaEmitterService.listen().subscribe( (cliente:Cliente) => {
                        this.Cliente = cliente;
            })
       
        }

}