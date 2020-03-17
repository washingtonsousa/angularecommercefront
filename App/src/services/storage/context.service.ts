import { Injectable } from '@angular/core';
import { ContextModel } from 'src/shared/models/context/context.model';


@Injectable()
export class ContextService {
  
        static get isLoggedIn(): boolean {
            return !(localStorage.getItem("Token") == undefined || localStorage.getItem("Token") == "");
        }

        static GetCurrentContext() : ContextModel {

           return {

                LojaId :  parseInt(((localStorage.getItem("LojaId") == undefined) ? "0" : localStorage.getItem("LojaId").toString())),
                PedidoId : parseInt(((localStorage.getItem("PedidoId") == undefined) ? "0" : localStorage.getItem("PedidoId").toString())),
                AuthToken :  localStorage.getItem("Token")


            } as ContextModel;

        }

        static Logout() {
            localStorage.setItem("LojaId", "0");
            localStorage.setItem("PedidoId", "0");
            localStorage.setItem("Token", "");
        }

        static setToken(Token:string) {
            localStorage.setItem("Token", Token);
        }


        static SetCurrentContext(context: ContextModel) {
             localStorage.setItem("LojaId", context.LojaId.toString());
             localStorage.setItem("PedidoId", context.PedidoId.toString());
             localStorage.setItem("Token", context.AuthToken.toString());
        }

}