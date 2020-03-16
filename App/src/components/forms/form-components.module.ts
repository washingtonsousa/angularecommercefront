import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { NumberControlInputComponent } from './number-control-input.component';
import { InputLabelAreaComponent } from './form-inputs/input-label-area.component';

@NgModule({
    imports: [ReactiveFormsModule, CommonModule, BrowserModule],
    declarations: [NumberControlInputComponent, InputLabelAreaComponent],
    exports: [NumberControlInputComponent, InputLabelAreaComponent]

})
export class FormComponentsModule {

}