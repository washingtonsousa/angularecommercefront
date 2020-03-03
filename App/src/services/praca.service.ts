import { Injectable } from '@angular/core';
import { StorageMap } from '@ngx-pwa/local-storage';
import { PracaModel } from 'src/shared/models/praca.model';


@Injectable()
export class PracaService {

            constructor(protected localStorage: StorageMap) {}

            public GetCurrentLoja() {
                return this.localStorage.get("loja");
            }

            public SetLoja(Loja:PracaModel) {
                return  this.localStorage.set("loja", Loja);
            }

}