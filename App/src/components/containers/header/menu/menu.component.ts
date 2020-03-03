import { Component, ViewChild, ElementRef, HostListener } from '@angular/core';
import * as $  from 'jquery';

@Component({
    selector: 'menu',
    templateUrl: 'menu.component.html',
})
export class MenuComponent {

            @ViewChild("navMobile", {static:false})   navMobile?: ElementRef<any>;

            constructor(private eRef: ElementRef) {
            }

            hideMobile() {
                $(this.navMobile.nativeElement).addClass("hide-menu");
            }

            showMobile() {
                $(this.navMobile.nativeElement).addClass("hide-menu");
            }

            toggleMobile() {
                $(this.navMobile.nativeElement).toggleClass("hide-menu");
            }

            @HostListener("window:click", ["$event"])
            clickOutside(event: any) {  
                
                    let isNavToggle = $(event.target).data("role") === "nav-mobile-toggle";

                    if(!this.navMobile.nativeElement.contains(event.target) && !isNavToggle)
                    this.hideMobile();
        
            }
}