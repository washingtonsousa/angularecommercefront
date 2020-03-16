import { Injectable } from '@angular/core';
import { HttpBasedService } from './abstractions/http-based-service';
import { ContextService } from './storage/context.service';
import { AuthenticateModel } from 'src/shared/models/request/auth.model';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from 'src/shared/models/cliente.model';
import { ResponseModelWithResult } from 'src/shared/models/response/response-model';
import * as jwt_decode from "jwt-decode";
import { JwtLoggedInData } from 'src/shared/models/jwt/logged-in-data';

@Injectable()
export class ClienteService extends HttpBasedService {

            constructor(contextService: ContextService,  private _http: HttpClient) {
                super(contextService);
            }


            GetCurrent(): Observable<ResponseModelWithResult<Cliente>> {
                return this._http.get<ResponseModelWithResult<Cliente>>(this.env.apiUrl + "cliente/GetCurrent", {headers: this.httpHeaders});
            }


}