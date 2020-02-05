import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import * as $  from 'jquery';

@Component({
    selector: 'menu',
    templateUrl: 'menu.component.html',
})
export class MenuComponent {

            @ViewChild("navMobile", {static:false})   navMobile?: ElementRef<any>;

            hideMobile() {
                $(this.navMobile.nativeElement).addClass("hide-menu");
            }

            showMobile() {
                $(this.navMobile.nativeElement).addClass("hide-menu");
            }

            toggleMobile() {
                $(this.navMobile.nativeElement).toggleClass("hide-menu");
            }

}