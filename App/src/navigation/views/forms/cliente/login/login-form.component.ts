import { Component, EventEmitter, Output } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { LoginService } from 'src/services/login.service';
import { Cliente } from 'src/shared/models/cliente.model';
import { ResponseModelWithResult } from 'src/shared/models/response/response-model';
import { ErrorResponseModel } from 'src/shared/models/response/error-response.model';
import { LoadingIconService } from 'src/services/emitters/loading-icon.service';
import { ContextService } from 'src/services/storage/context.service';

@Component({
        selector: "login-form",
        templateUrl: "login-form.html"
})
export class LoginFormComponent {

    formGroup: FormGroup;
    @Output() OnLoggedIn: EventEmitter<any> = new  EventEmitter<any>();
    @Output() OnError: EventEmitter<any> = new  EventEmitter<any>();

    constructor(private _formBuilder: FormBuilder, private _loginService:LoginService) {

      this.formGroup =  this._formBuilder.group({
            UserName: ["", [Validators.required]],
            Password: ["", [Validators.required]]
        })

    }

    Submit(event) {

        LoadingIconService.show();
        event.preventDefault();

        this._loginService.Auth(this.formGroup.value).subscribe((response: ResponseModelWithResult<Cliente>) => {
            ContextService.setToken(response._result.Token.toString());
            this.OnLoggedIn.emit(response);
            LoadingIconService.hide(); 
        }, (err:ErrorResponseModel) => {
            LoadingIconService.hide();
            this.OnError.emit(err.error);
        });

    }


}