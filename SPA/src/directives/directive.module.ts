import { NgModule } from '@angular/core';
import { NumberOnlyDirective } from './helpers/number-only.directive';
import { MaxLengthDirective } from './helpers/max-length.directive';



@NgModule({
 imports: [],
 exports: [NumberOnlyDirective, MaxLengthDirective],
 declarations: [NumberOnlyDirective,MaxLengthDirective]
})
export class DirectiveModule {

}