import { Component, Output, EventEmitter } from '@angular/core';
import { ControlValueAccessor } from '@angular/forms';

@Component({
    selector: "number-control-input",
    templateUrl: "number-control-input.component.html"
})
export class NumberControlInputComponent implements ControlValueAccessor {

    Quantidade: number = 0;
    @Output() OnChange: EventEmitter<number> = new EventEmitter<number>();
    @Output() OnIncrement: EventEmitter<number> = new EventEmitter<number>();
    @Output() OnDecrement: EventEmitter<number> = new EventEmitter<number>();
    propagateChange = (_: any) => {};

    writeValue(obj: any): void {
       this.Quantidade = obj;
    }    
    
    registerOnChange(fn: any): void {
        this.propagateChange = fn;
    }

    increment() {
        this.Quantidade += 1;
        this.OnChange.emit(this.Quantidade);
        this.OnIncrement.emit(this.Quantidade);
        this.propagateChange(this.Quantidade);
    }

    decrement() {
        this.Quantidade -= 1;
        this.OnChange.emit(this.Quantidade);
        this.OnDecrement.emit(this.Quantidade);
        this.propagateChange(this.Quantidade);
    }

    registerOnTouched(fn: any): void {
    }

    setDisabledState?(isDisabled: boolean): void {
    }
}