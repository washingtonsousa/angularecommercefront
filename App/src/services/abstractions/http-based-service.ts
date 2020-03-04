import { HttpHeaders } from '@angular/common/http';
import { ContextService } from '../storage/context.service';
import { ContextModel } from 'src/shared/models/context/context.model';
import { Inject } from '@angular/core';

export abstract class HttpBasedService {
    
    public httpHeaders: HttpHeaders;
    protected _contextService: ContextService;
    private _context:ContextModel;

    constructor(contextService: ContextService) {

        this._contextService = contextService;
        this._contextService.GetCurrentContext().subscribe( (result: ContextModel) => {

            this._context = (result == undefined || result == null) ? new ContextModel() : result;

            this.httpHeaders = new HttpHeaders({
                "Context-Type": "application/json",
                "X-Pedido-Sessao" :  this._context.PedidoId.toString(),
                "X-Loja-Id" : this._context.LojaId.toString()
            })

        })

    }

}