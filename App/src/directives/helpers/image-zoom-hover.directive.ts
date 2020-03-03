import { Directive, HostListener, ElementRef, OnInit, Input, OnChanges, SimpleChange, SimpleChanges } from '@angular/core';
import * as $ from "jquery";

@Directive({
    selector: '[imageZoomHover]'
})
export class ImageZoomHoverDirective implements OnInit {

    @Input() zoomScale: number = 1;

    constructor(private eRef:ElementRef) {}

    @HostListener("mouseover", ['$event'])    
    @HostListener("mousemove", ['$event'])
    OnHover(event: MouseEvent) {

            this.setScale();
            let jEl = $(this.eRef.nativeElement);
            jEl.css({'transform-origin': ((event.pageX - jEl.offset().left) / jEl.width()) * 100 + '% ' + ((event.pageY - jEl.offset().top) / jEl.height()) * 100 +'%'});
    
    }

    @HostListener("mouseout", ['$event'])    
    @HostListener("mouseleave", ['$event'])
    OnLeave(event: MouseEvent) {

           this.unsetScale();
    
    }

    private setScale() {

        $(this.eRef.nativeElement).css({ transform: 'scale('+this.zoomScale+')'  });

    }

    private unsetScale() {

        $(this.eRef.nativeElement).css({ transform: 'scale(1)'  });
        
    }

    ngOnInit() {
    }

}