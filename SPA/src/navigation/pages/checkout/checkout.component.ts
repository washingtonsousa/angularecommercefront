import { Component, OnInit, OnChanges, ChangeDetectorRef } from '@angular/core';
import { RodapeModel } from 'src/shared/models/rodape.model';



@Component({
    selector: 'checkout',
    templateUrl: 'checkout.html'
})
export class CheckoutComponent implements OnInit, OnChanges {

    public RodapeModel: RodapeModel;


    constructor(private cdRef:ChangeDetectorRef) {

    }

    ngOnChanges() {
        this.cdRef.detectChanges();
    }

    ngOnInit() {

        this.RodapeModel.Rodape =  `<div class="row first-description mb-3">
        <div class="col-xl-5">
            <h4 class="subheader"><img src="assets/images/anvisa.png" alt="anvisa"></h4>
        </div>
        <div class="col-xl-7">
            <span style="color:#ec2856">
                <strong>A xxxxxxxxxxxxxxxx segue as determinações da Anvisa.&nbsp;</strong>
            </span>
            <br>As informações contidas neste site não devem ser usadas para automedicação e não substituem,
            em
            hipótese alguma,
            as orientações dadas pelo profissional da área médica. Somente o médico está apto a diagnosticar
            qualquer problema de saúde e prescrever o tratamento adequado.
        </div>
    </div>
    <div class="row second-description">
        <div class="col-sm-12 text">Razão Social: xxxxxxxxxxxxxxxxxxxxx | Nome
            Fantasia:&nbsp;xxxxxxxxxxxxxxxx|
            CNPJ:&nbsp;xxxxxxxxxxxxxxxxxxx
            | Rua xxxxxxxxxxxxx, xxxx - xxxxxxxxxx - xxxxxxxxxxx - xx - CEP: xxxxxxxxxxx
            | Telefone:&nbsp;(xx) xxxx-xxxx| Horário de Funcionamento: xxxxxxxxxxxxxxxxxxxxxxx&nbsp;|
            Farmacêutico Responsável:&nbsp;xxxxxxxxxxxxxxxxxxxxxxxxx
            | CRF/xxxx: xxxxxxxx |Autorização de Funcionamento da Empresa (AFE): xxxxxxxxxxxxxxxxxxx</div>
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

        }


];

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

    }

]



    }


}