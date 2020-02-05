import { Injectable } from '@angular/core';
import {  StorageMap } from '@ngx-pwa/local-storage';
import { Observable } from 'rxjs';

@Injectable()
export class PedidoService {

    constructor(protected localStorage: StorageMap) {}

    GetCurrentPedido()  {
           return this.localStorage.get("pedido");
    }

    SetPedidoOnStorage(Pedido) {
          return   this.localStorage.set("pedido", Pedido);
    }

    UpdatePedido(Pedido) {
        return  this.localStorage.set("pedido", Pedido);
    }

}