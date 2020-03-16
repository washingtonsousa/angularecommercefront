import { Component, Input, EventEmitter, OnInit, ChangeDetectorRef, Renderer2, Output } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { LoginService } from 'src/services/login.service';
import { Cliente } from 'src/shared/models/cliente.model';
import { ResponseModelWithResult } from 'src/shared/models/response/response-model';
import { ErrorResponseModel } from 'src/shared/models/response/error-response.model';
import { FormComponentTemplate } from '../../abstractions/form-component-template';
import {LoadingIconService} from 'src/services/emitters/loading-icon.service';

@Component({
    selector: "cadastro-form",
    templateUrl: "cadastro-form.component.html"
})
export class CadastroFormComponent extends FormComponentTemplate implements OnInit {

    @Output() OnSubscribe: EventEmitter<any> = new  EventEmitter<any>();
    @Output() OnError: EventEmitter<any> = new  EventEmitter<any>();
    @Input() model: Cliente = new Cliente();
    errorMessage: string = "";

    constructor(private _formBuilder: FormBuilder, 
        private _loginService:LoginService, 
        protected cdRef: ChangeDetectorRef,
        protected renderer: Renderer2) {

            super();

        }

    ngOnInit() {
            this.buildFormGroup();
    }

    buildFormGroup() {

        this.formGroup =  this._formBuilder.group({

                    IdCliente: [this.model.IdCliente],
                    FlTipoPessoa: [this.model.FlTipoPessoa, [Validators.required]],
                    FlSexo: [this.model.FlSexo, [Validators.required]],
                    FlAceitaMailing: [this.model.FlAceitaMailing],
                    DtNascimento: [this.model.DtNascimento, [Validators.required]],
                    NmCliente: [this.model.NmCliente, [Validators.required]],
                    DsCpfCnpj: [this.model.DsCpfCnpj, [Validators.required]],
                    DsEmail: [this.model.DsEmail, [Validators.required, Validators.email]],
                    DsSenha: [this.model.DsSenha, [Validators.required]],
                    DsTelefoneDdd: [this.model.DsTelefoneDdd, []],
                    DsCelularDdd: [this.model.DsCelularDdd, []],
                    DsTelefone: [this.model.DsTelefone, []],
                    DsCelular: [ this.model.DsCelular, []],
                    TelefoneCompleto: [this.model.DsTelefoneDdd + this.model.DsTelefone, [Validators.pattern("([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])")]],
                    CelularCompleto: [ this.model.DsCelularDdd + this.model.DsCelular, [Validators.required, Validators.pattern("([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])([0-9])")]],
                    NomeSocial: [this.model.NomeSocial]
    
            });

    }

    formatPhones(value) {

        let obj = value;

        
        obj.DsTelefoneDdd = (value.TelefoneCompleto != null) ? value.TelefoneCompleto.substr(0,2) : null;
        obj.DsTelefone = (value.TelefoneCompleto != null) ? value.TelefoneCompleto.substr(2,9) : null;


        obj.DsCelularDdd = value.CelularCompleto.substr(0,2);
        obj.DsCelular = value.CelularCompleto.substr(2,9);
       

        return obj;

    }

    Submit(event) {

        LoadingIconService.show();
        event.preventDefault();

         this._loginService.Subscribe(this.formatPhones(this.formGroup.value)).subscribe((response: ResponseModelWithResult<Cliente>) => {
      
             this.OnSubscribe.emit( response._result);
             LoadingIconService.hide();

         }, (err:ErrorResponseModel) => {

             this.OnError.emit(err.error);
             this.errorMessage = err.error.shift().Value;
             LoadingIconService.hide();
    
         });

    }
}