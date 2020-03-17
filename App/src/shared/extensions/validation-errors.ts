import { AbstractControl, FormGroup, ValidationErrors, FormControl } from '@angular/forms';

export interface AllValidationErrors {
  control_name: string;
  error_name: string;
  error_value: any;
}

export interface FormGroupControls {
  [key: string]: AbstractControl;
}

export function getFormValidationErrors(controls: FormGroupControls): AllValidationErrors[] {
  let errors: AllValidationErrors[] = [];
  Object.keys(controls).forEach(key => {
    const control = controls[ key ];
    if (control instanceof FormGroup) {
      errors = errors.concat(getFormValidationErrors(control.controls));
    }
    const controlErrors: ValidationErrors = controls[ key ].errors;
    if (controlErrors !== null) {
      Object.keys(controlErrors).forEach(keyError => {
        errors.push({
          control_name: key,
          error_name: keyError,
          error_value: controlErrors[ keyError ]
        });
      });
    }
  });
  return errors;
}

export function getFormControlValidationErrors(control: AbstractControl): AllValidationErrors[] {
  let errors: AllValidationErrors[] = [];
 
    const controlErrors: ValidationErrors = control.errors;

    if (controlErrors !== null) {
      Object.keys(controlErrors).forEach(keyError => {
        errors.push({
          control_name: null,
          error_name: keyError,
          error_value: controlErrors[ keyError ]
        });
      });
    }
console.log(errors);
  return errors;
}

export function getControlErrorsList(control: AbstractControl) {

let errors: AllValidationErrors[] = getFormControlValidationErrors(control);
let stringList: ControlObj[] = [];

    for(let error of errors) {

          let text;

          switch (error.error_name) {
            case 'required': text =   `Este campo é obrigatório!`; break;
            case 'pattern': text = `Formato incorreto`; break;
            case 'email': text = ` Email inválido ou preenchido incorretamente.`; break;
            case 'minlength': text = ` Mínimo de caractéres inválido! Mínimo requerido: ${error.error_value.requiredLength}`; break;
            case 'areEqual': text = `Devem ser iguais`; break;
            default: text = `Esse campo não está preenchido corretamente`;
          }

      stringList.push( { touched: control.touched, errorMessage: text });

    }
console.log(stringList);
    return stringList;
}


export class ControlObj {
  touched: boolean = false;
  errorMessage: string = "";
}