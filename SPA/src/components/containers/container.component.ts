import { Component, Input, OnInit, ChangeDetectorRef, OnChanges } from '@angular/core';
import { RodapeModel } from 'src/shared/models/rodape.model';

@Component({
    selector: 'container',
    templateUrl: 'container.component.html'
})
export class ContainerComponent implements OnInit, OnChanges {

        @Input() RodapeModel: RodapeModel = new RodapeModel();

        constructor(private cdRef:ChangeDetectorRef) {

        }

        ngOnChanges() {
            this.cdRef.detectChanges();
        }

        ngOnInit() {

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