import { ContextService } from '../storage/context.service';
import { Observable } from 'rxjs';
import { HttpHandler, HttpRequest, HttpInterceptor, HttpEvent } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class TokenInterceptor implements HttpInterceptor {
  constructor() {}
  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
 
    request = request.clone({
      setHeaders: {
            "X-Pedido-Sessao" :  ContextService.GetCurrentContext().PedidoId.toString(),
            "X-Loja-Id" :  ContextService.GetCurrentContext().LojaId.toString(),
            "Authorization" : "Bearer " +  ContextService.GetCurrentContext().AuthToken
      }
    });
    return next.handle(request);
  }
}