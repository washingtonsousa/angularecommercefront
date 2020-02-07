import { Component, OnInit, OnChanges, ChangeDetectorRef } from '@angular/core';
import { RodapeModel } from 'src/shared/models/rodape.model';
import { PedidoService } from 'src/services/pedido.service';
import { PedidoModel } from 'src/shared/models/pedido.model';
import { Router } from '@angular/router';

@Component({
    selector: 'checkout',
    templateUrl: 'checkout.html'
})
export class CheckoutComponent implements OnInit, OnChanges {

    public RodapeModel: RodapeModel = new RodapeModel();
    private Pedido?: PedidoModel;
    private Parcelas: String[] = [];

    isCartao: boolean = false;
    isBoleto: boolean = true;

    constructor(private cdRef:ChangeDetectorRef, private _pedidoService: PedidoService, private _router: Router) {}

    public finalizarCartao(event:MouseEvent) {
        event.preventDefault();
        this._router.navigate(["/confirmacao"]);
    }

    public finalizarBoleto(event:MouseEvent) {
        event.preventDefault();
        this._router.navigate(["/confirmacao"]);
    }

    ngOnChanges() {
        this.cdRef.detectChanges();
    }

    private ConstructParcelas() {
        this.Parcelas = [];
        this.Parcelas.push("1x R$ " + this.Pedido.Total.toFixed(2));
        this.Parcelas.push("2x R$ " + (this.Pedido.Total / 2).toFixed(2));
        this.Parcelas.push("3x R$ " + (this.Pedido.Total /3).toFixed(2));
    }

    ngOnInit() {

        this._pedidoService.GetCurrentPedido().subscribe((Pedido: PedidoModel) => {
            this.Pedido = Pedido;
            this.ConstructParcelas();

        });

        this.RodapeModel.Rodape =  `<div class="row first-description mb-3">
            <div class="col-xl-5">
                <h4 class="subheader"><img src="assets/images/anvisa.png" alt="anvisa"></h4>
            </div>
            <div class="col-xl-7">
                <span style="color:#ec2856">
                    <strong>A FARMÁCIA NACIONAL segue as determinações da Anvisa.&nbsp;</strong>
                </span>
                <br>As informações contidas neste site não devem ser usadas para automedicação e não substituem,
                em
                hipótese alguma,
                as orientações dadas pelo profissional da área médica. Somente o médico está apto a diagnosticar
                qualquer problema de saúde e prescrever o tratamento adequado.
            </div>
            </div>
            <div class="row second-description">
                <div class="col-sm-12 text">Razão Social: Produtos Farmacêuticos Borges Ltda  | Nome
                Fantasia:Farmácia Nacional|
                CNPJ:&nbsp;22.020.994/0013-84
                | Avenida Faria Pereira, 2033- Centro - CEP: 38.740-024
                | Telefone:&nbsp;(34) 3832.1000| Horário de Funcionamento: das 08h às 22h&nbsp;|
                Farmacêutico Responsável:&nbsp;Dr. Frederico da Cruz Germano - CRF/MG: 16.639 | Alvará Sanitário: 003/17| Autorização de Funcionamento da Empresa (AFE): 77176732</div>
            <div class="col-sm-12"><br>
                <div><span
                        style="font-size:small">
                        <span>
                                <span>Os preços e as promoções são válidos apenas para compras via internet. | As
                                    fotos
                                    contidas em nosso site são meramente ilustrativas.
                                    | *Preços e disponibilidade sujeitos a alterações no decorrer do dia.
                                </span>
                            </span>
                        </span>
                    </div>
                </div>
            </div>`;

        
        this.RodapeModel.Pagamentos = [
            {
                Logo: "/BACKOFFICE/Uploads/Pagamento/6.jpg"
            },

            {
                Logo: "/BACKOFFICE/Uploads/Pagamento/16.jpg"
            }];

        this.RodapeModel.RedesSociais = [

            {
                Logo: "/BACKOFFICE/Uploads/redessociais/facebook.png"
            },

            {
                Logo: "/BACKOFFICE/Uploads/redessociais/google.png"
            },

            {
                Logo: "/BACKOFFICE/Uploads/redessociais/twiiter.png"
            },

            {
                Logo: "/BACKOFFICE/Uploads/redessociais/pinterest.png"
            }];
    }
}