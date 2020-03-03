import { Component, OnInit } from '@angular/core';
import { GlobalEventEmittersService } from 'src/services/emitters/global-event-emitters.service';

@Component({
    selector: 'loading-icon',
    template: `
     <div *ngIf="Show" class="mask-loading"> <div class="lds-ripple"><div></div><div></div></div></div>
    `,
    styleUrls: ["loading-icon.scss"]
})
export class LoadingIconComponent implements OnInit {

            public Show: boolean = false;

            show() {
                    this.Show = true;
            }

            hide() {
                this.Show = false;
            }

            toggle() {
                this.Show = (this.Show == true) ? false : true;
            }

            ngOnInit() {

                GlobalEventEmittersService.get("loading-icon-evt").subscribe((config: any) => {
                        this.Show = config.Show;
                });

            }
}