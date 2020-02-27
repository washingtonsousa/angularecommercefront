import { Component, Input } from '@angular/core';
import { ProdutoModel } from 'src/shared/models/produto.model';
import { trigger, state, transition, animate, style } from '@angular/animations';

@Component({
    selector: 'product-card',
    templateUrl: 'product-card.component.html',
    styleUrls: ["product-card.scss"],
    animations: [ trigger( "addAnimation", [

        state('show', style({
            opacity: '1',
            visibility: "visible"
          })),
          state('inprocess', style({
            opacity: '0',
            visibility: "visible"
          })),
          state('hidden', style({
            opacity: '0',
            visibility: "hidden"
          })),
          transition('show <=> inprocess', [
            animate('.2s')
          ]),

          transition('hidden <=> inprocess', [
            animate('.2s')
          ]),
  

    ]) ]
})
export class ProductCardComponent {
       @Input() public Produto: ProdutoModel;
       @Input() public Carrosel: boolean = true;

       public AnimationState: String = "hidden";
       private timeOut = null;

       ShowMessage() {

        this.timeOut = null;
        this.AnimationState = "hidden";
        this.AnimationState = "inprocess";

        this.timeOut =  setTimeout(() => {
            this.AnimationState = "show"
            
            setTimeout(() => {

                this.AnimationState = "inprocess"

                setTimeout(() =>{     this.AnimationState = "hidden" }, 
                
                400);

            }, 500);
  
        }, 500);

       }

}