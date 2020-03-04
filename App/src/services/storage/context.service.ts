import { Injectable } from '@angular/core';
import { StorageMap } from '@ngx-pwa/local-storage';
import { ContextModel } from 'src/shared/models/context/context.model';


@Injectable()
export class ContextService {

        constructor(protected localStorage: StorageMap) {}    

        GetCurrentContext() {
            return this.localStorage.get<ContextModel>("context");
        }

        SetCurrentContext(context: ContextModel) {
            return this.localStorage.set("context", context);
        }

}