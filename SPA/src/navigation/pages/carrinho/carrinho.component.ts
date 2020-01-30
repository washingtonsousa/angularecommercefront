import {Component, ViewChild, ElementRef} from "@angular/core";


@Component({
    selector: 'carrinho',
    templateUrl: 'carrinho.component.html'
})
export class CarrinhoComponent {

    private CEP: String = "";

    private get cepOk(): boolean {
        return this.CEP.length == 8;
    }
 
    private Lojas: any[] = [{

        Logo: "unifabra_logo.png"

    }, {

        Logo: "vfarma.png"

    }, {

        Logo: "logo-50.png"

    }];


    public  OnCepInputChange() {

       

    }


}