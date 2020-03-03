import { Directive, Input, HostListener, ElementRef } from "@angular/core";

@Directive({
    selector: '[maxLength]'
})
export class MaxLengthDirective {

    private maxLength: number = 99999999;

    constructor(private el: ElementRef) { }

    @HostListener('keydown', ['$event']) 
    @HostListener('keyup', ['$event']) 
    @HostListener('paste', ['$event']) 
    @HostListener('change', ['$event']) 
    onChange(event) {
    
      let e = <KeyboardEvent> event;
        
            if(event.target.value.length > this.maxLength) {
                this.el.nativeElement.value = this.el.nativeElement.value.substring(0, this.maxLength);
            }


      }


    }