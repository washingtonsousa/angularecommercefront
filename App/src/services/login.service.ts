import { Injectable } from '@angular/core';
import { HttpBasedService } from './abstractions/http-based-service';
import { ContextService } from './storage/context.service';
import { AuthenticateModel } from 'src/shared/models/request/auth.model';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from 'src/shared/models/cliente.model';
import { ResponseModelWithResult } from 'src/shared/models/response/response-model';

@Injectable()
export class LoginService extends HttpBasedService {

            constructor(contextService: ContextService,  private _http: HttpClient) {
                super(contextService);
            }

            Auth(model: AuthenticateModel): Observable<ResponseModelWithResult<Cliente>> {
                return this._http.post<ResponseModelWithResult<Cliente>>(this.env.apiUrl + "login/auth", model);
            }


            Subscribe(model: Cliente): Observable<ResponseModelWithResult<any>> {
                return this._http.post<ResponseModelWithResult<any>>(this.env.apiUrl + "login/Subscribe", model);
            }

            Update(model: Cliente): Observable<ResponseModelWithResult<any>> {
                return this._http.post<ResponseModelWithResult<any>>(this.env.apiUrl + "login/Update", model);
            }

}