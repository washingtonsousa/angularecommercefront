import { Injectable } from '@angular/core';
import { LocalStorage } from '@ngx-pwa/local-storage';


@Injectable()
export class PedidoService {

    constructor(protected localStorage: LocalStorage) {}


    GetCurrentPedido() {

            this.localStorage.getItem("pedido");

    }

    SetPedidoOnStorage(Pedido) {
            this.localStorage.setItem("pedido", Pedido);
    }

}