import { Component, OnInit, Input } from '@angular/core';
import { RodapeModel } from 'src/shared/models/rodape.model';



@Component({
    selector: 'main-footer',
    templateUrl: 'footer.component.html'
})
export class FooterComponent implements OnInit {

        @Input() public RodapeModel: RodapeModel = new RodapeModel();

        ngOnInit() {
        }

}