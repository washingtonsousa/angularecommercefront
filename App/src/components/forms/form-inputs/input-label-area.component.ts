import { Component, Input,  OnInit, OnChanges, ChangeDetectorRef, SimpleChanges } from '@angular/core';
import { AbstractControl } from '@angular/forms';
import * as ValidationErrorsHelper from "src/shared/extensions/validation-errors";

@Component({
        selector: "input-label-area",
        templateUrl: "input-label-area.component.html"
})

export class InputLabelAreaComponent implements OnInit, OnChanges {
    
    @Input() label:string = "";
    @Input() control: AbstractControl;
    ValidationErrorsHelper = ValidationErrorsHelper;
    errors: string[] = [];
    @Input() required: boolean = false;

    constructor(private cdRef: ChangeDetectorRef) {}

    ngOnChanges(changes: SimpleChanges): void {
        this.detectErrors();
    }

    ngOnInit(): void {
        this.detectErrors();
    }

    detectErrors() {

        if(this.control != undefined)
        this.control.statusChanges.subscribe((val) => {

            this.errors = ValidationErrorsHelper.getControlErrorsList(this.control);

        });

        this.control.valueChanges.subscribe((val) => {

            this.errors = ValidationErrorsHelper.getControlErrorsList(this.control);

        });

    }
}