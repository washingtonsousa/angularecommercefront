import {Injectable} from "@angular/core";
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import * as env from  "src/environments/environment";
import { DepartamentoModel } from 'src/shared/models/departamento.model';
import { ContextService } from './storage/context.service';

@Injectable()
export class DepartamentoService {

            constructor(private _http: HttpClient) {
            }

            public GetMenuDepartamentos() : Observable<DepartamentoModel[]> {
                return this._http.get<DepartamentoModel[]>(
                    env.environment.apiUrl + "Departamento/GetMenuDepartamentos", 
                {}
                );
            }

}