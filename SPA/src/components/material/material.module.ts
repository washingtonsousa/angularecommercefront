import { NgModule } from '@angular/core';
import { ModalModule } from 'ngx-bootstrap';
import { CommonModule } from '@angular/common';
import { ModalComponent } from './modal/modal.component';
import { TabsModule } from 'ngx-bootstrap';
import { LoadingIconComponent } from './loaders/loading-icon.component';
import { PedidoService } from 'src/services/pedido.service';


@NgModule({
    providers: [PedidoService],
    exports: [ModalComponent, LoadingIconComponent],
    declarations: [ModalComponent, LoadingIconComponent],
    imports: [ModalModule, CommonModule, TabsModule]
})
export class MaterialModule {

}