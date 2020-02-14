import { Component, TemplateRef, ViewChild, Input, Output, EventEmitter } from '@angular/core';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
    selector: 'modal-confirm',
    templateUrl: 'modal-confirm.component.html'
})
export class ModalConfirmComponent {

     @ViewChild("modal", { static: false })   private template: TemplateRef<any>;
     modalRef: BsModalRef;
     @Input() Title: string = "";
     @Input() Icon: string = "fa fa-question";  
     @Input() ModalClass: string = "modal-lg ";
     @Input() TitleClass: string = "";
     @Input() DenyText:String = "Não";
     @Input() ConfirmText: String = "Sim";   

     @Output() OnConfirm: EventEmitter<any> = new EventEmitter<any>();

    constructor(private modalService: BsModalService) {}

    public open() {
        this.modalRef = this.modalService.show(this.template,  Object.assign({}, { class:  this.ModalClass  }));
    }

    public close() {
         this.modalRef.hide();
    }

}