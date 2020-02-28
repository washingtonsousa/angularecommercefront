import { Directive, Input, HostListener, ElementRef } from "@angular/core";

@Directive({
    selector: '[numberOnly]'
})
export class NumberOnlyDirective {


    constructor(private el: ElementRef) { }

    @Input() numberOnly: boolean;
  
    @HostListener('keydown', ['$event']) 
    @HostListener('keyup', ['$event']) 
    @HostListener('paste', ['$event']) 
    @HostListener('change', ['$event']) 
    onChange(event) {
        console.log("teste");
      let e = <KeyboardEvent> event;
      if (this.numberOnly) {
        if ([46, 8, 9, 27, 13, 110, 190].indexOf(e.keyCode) !== -1 ||
          // Allow: Ctrl+A
          (e.keyCode === 65 && (e.ctrlKey || e.metaKey)) ||
          // Allow: Ctrl+C
          (e.keyCode === 67 && (e.ctrlKey || e.metaKey)) ||
          // Allow: Ctrl+V
          (e.keyCode === 86 && (e.ctrlKey || e.metaKey)) ||
          // Allow: Ctrl+X
          (e.keyCode === 88 && (e.ctrlKey || e.metaKey)) ||
          // Allow: home, end, left, right
          (e.keyCode >= 35 && e.keyCode <= 39)) {
            // let it happen, don't do anything

            this.el.nativeElement.value = this.el.nativeElement.value.replace(/\D+/g, '');

            return;
          }
          // Ensure that it is a number and stop the keypress
          if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
              e.preventDefault();
          }




        }
      }

}