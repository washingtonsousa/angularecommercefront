import { Injectable } from '@angular/core';
import { HttpBasedService } from './abstractions/http-based-service';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { Cliente } from 'src/shared/models/cliente.model';
import { ResponseModelWithResult } from 'src/shared/models/response/response-model';


@Injectable()
export class ClienteService extends HttpBasedService {

         
            constructor(private _http: HttpClient) {
                super();
            }

            GetCurrent(): Observable<ResponseModelWithResult<Cliente>> {
                return this._http.get<ResponseModelWithResult<Cliente>>(this.env.apiUrl + "cliente/GetCurrent", {});
            }

    

}