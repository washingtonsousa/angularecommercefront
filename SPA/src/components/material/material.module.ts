import { NgModule } from '@angular/core';
import { ModalModule } from 'ngx-bootstrap';
import { CommonModule } from '@angular/common';
import { ModalComponent } from './modal/modal.component';



@NgModule({
    exports: [ModalComponent],
    declarations: [ModalComponent],
    imports: [ModalModule, CommonModule]
})
export class MaterialModule {

}