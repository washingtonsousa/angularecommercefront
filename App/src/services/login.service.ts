import { Injectable } from '@angular/core';
import { HttpBasedService } from './abstractions/http-based-service';
import { ContextService } from './storage/context.service';
import { AuthenticateModel } from 'src/shared/models/request/auth.model';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { Cliente } from 'src/shared/models/cliente.model';
import { ResponseModelWithResult } from 'src/shared/models/response/response-model';
import { JwtLoggedInData } from 'src/shared/models/jwt/logged-in-data';
import * as jwt_decode from "jwt-decode";


@Injectable()
export class LoginService extends HttpBasedService {

    currentClienteLoggedIn: BehaviorSubject<JwtLoggedInData> = new BehaviorSubject<JwtLoggedInData>(null);


            constructor(private _http: HttpClient) {
                super();
                this.decodeAndNotify();
            }

            Auth(model: AuthenticateModel): Observable<ResponseModelWithResult<Cliente>> {
                return this._http.post<ResponseModelWithResult<Cliente>>(this.env.apiUrl + "login/auth", model);
            }

            Subscribe(model: Cliente): Observable<ResponseModelWithResult<any>> {
                return this._http.post<ResponseModelWithResult<any>>(this.env.apiUrl + "login/Subscribe", model);
            }

            Update(model: Cliente): Observable<ResponseModelWithResult<any>> {
                return this._http.put<ResponseModelWithResult<any>>(this.env.apiUrl + "login/Update", model);
            }



            decodeAndNotify()  {

                try{
                    this.currentClienteLoggedIn.next(jwt_decode(localStorage.getItem("Token")) as JwtLoggedInData);
                }
                catch(Error){
                    return null;
                }
                
            }

            fullLogOut() {
                ContextService.Logout();
                this.currentClienteLoggedIn.next(null);
            }

}