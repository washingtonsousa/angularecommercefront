import { PedidoModel } from 'src/shared/models/pedido.model';
import { GlobalEventEmittersService } from './global-event-emitters.service';



export class CestaProdutoService {

       static update(Pedido: PedidoModel) {
                    GlobalEventEmittersService.get("update-cesta").emit(Pedido);
       }

       static listen() {
           return GlobalEventEmittersService.get("update-cesta");
       }

}