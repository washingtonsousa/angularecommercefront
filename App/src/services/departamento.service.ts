import {Injectable} from "@angular/core";
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import * as env from  "src/environments/environment";
import { DepartamentoModel } from 'src/shared/models/departamento.model';
import { HttpBasedService } from './abstractions/http-based-service';
import { ContextService } from './storage/context.service';

@Injectable()
export class DepartamentoService extends HttpBasedService {

            constructor(private _http: HttpClient, protected _contextService: ContextService) {
                super(_contextService);
            }

            public GetMenuDepartamentos() : Observable<DepartamentoModel[]> {
                return this._http.get<DepartamentoModel[]>(
                    env.environment.apiUrl + "Departamento/GetMenuDepartamentos", 
                {headers: this.httpHeaders}
                );
            }

}