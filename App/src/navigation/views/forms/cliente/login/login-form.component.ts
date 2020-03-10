import { Component, Input, EventEmitter } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { LoginService } from 'src/services/login.service';
import { Cliente } from 'src/shared/models/cliente.model';
import { ResponseModelWithResult } from 'src/shared/models/response/response-model';
import { LoginAreaEmitterService } from 'src/services/emitters/login-area-emitter.service';
import { HttpErrorResponse } from '@angular/common/http';
import { ErrorResponseModel } from 'src/shared/models/response/error-response.model';

@Component({
        selector: "login-form",
        templateUrl: "login-form.html"
})
export class LoginFormComponent {

    formGroup: FormGroup;
    @Input() OnLoggedIn: EventEmitter<any> = new  EventEmitter<any>();
    @Input() OnError: EventEmitter<any> = new  EventEmitter<any>();

    constructor(private _formBuilder: FormBuilder, private _loginService:LoginService) {

      this.formGroup =  this._formBuilder.group({
            UserName: ["", [Validators.required]],
            Password: ["", [Validators.required]]
        })

    }

    Submit(event) {

        event.preventDefault();

        this._loginService.Auth(this.formGroup.value).subscribe((response: ResponseModelWithResult<Cliente>) => {

            LoginAreaEmitterService.update(response._result);
            this.OnLoggedIn.emit(response);

        }, (err:ErrorResponseModel) => {

            this.OnError.emit(err.error);

        });

    }


}