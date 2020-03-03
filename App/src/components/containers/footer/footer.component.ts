import { Component, OnInit, Input } from '@angular/core';
import { RodapeModel } from 'src/shared/models/rodape.model';

@Component({
    selector: 'main-footer',
    templateUrl: 'footer.component.html'
})
export class FooterComponent implements OnInit {

        @Input() ShowNewsLetterForm: boolean = true;
        @Input() ShowWidgets: boolean = true;

        @Input() public RodapeModel: RodapeModel = new RodapeModel();

        ngOnInit() {
        }
}