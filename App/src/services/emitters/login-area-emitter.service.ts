import { GlobalEventEmittersService } from './global-event-emitters.service';
import { Cliente } from 'src/shared/models/cliente.model';


export class LoginAreaEmitterService {

       static update(cliente: Cliente) {
                    GlobalEventEmittersService.get("update-login").emit(cliente);
       }

       static listen() {
           return GlobalEventEmittersService.get("update-login");
       }

}