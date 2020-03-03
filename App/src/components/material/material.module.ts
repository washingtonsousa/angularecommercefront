import { NgModule } from '@angular/core';
import { ModalModule } from 'ngx-bootstrap';
import { CommonModule } from '@angular/common';
import { ModalComponent } from './modal/modal.component';
import { TabsModule } from 'ngx-bootstrap';
import { LoadingIconComponent } from './loaders/loading-icon.component';
import { PedidoService } from 'src/services/pedido.service';
import { ModalConfirmComponent } from './modal/modal-confirm/modal-confirm.component';


@NgModule({
    providers: [PedidoService],
    exports: [ModalComponent, LoadingIconComponent, ModalConfirmComponent],
    declarations: [ModalComponent, LoadingIconComponent, ModalConfirmComponent],
    imports: [ModalModule, CommonModule, TabsModule]
})
export class MaterialModule {

}