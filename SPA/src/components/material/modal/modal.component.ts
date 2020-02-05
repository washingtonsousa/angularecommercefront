import { Component, TemplateRef, ViewChild, Input } from '@angular/core';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
    selector: 'modal',
    templateUrl: 'modal.component.html'
})
export class ModalComponent {

     @ViewChild("modal", { static: false })   private template: TemplateRef<any>;
     modalRef: BsModalRef;
     @Input() Title: string = "";
     @Input() Icon: string = "fa fa-info";  
     @Input() ModalClass: string = "";
     @Input() TitleClass: string = "";
     constructor(private modalService: BsModalService) {
         
     }

    public open() {
        this.modalRef = this.modalService.show(this.template,  Object.assign({}, { class: 'modal-lg ' + this.ModalClass  }));
    }

    public close() {
         this.modalRef.hide();
    }

}