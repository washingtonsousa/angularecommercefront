import { NgModule } from '@angular/core';
import { NumberOnlyDirective } from './helpers/number-only.directive';
import { MaxLengthDirective } from './helpers/max-length.directive';
import { ImageZoomHoverDirective } from './helpers/image-zoom-hover.directive';
import { VerFarmaciaDirective } from './functions/ver-farmacia.directive';
import { AdicionarCestaDirective } from './functions/adicionar-cesta.directive';

@NgModule({
 imports: [],
 exports: [NumberOnlyDirective, MaxLengthDirective, ImageZoomHoverDirective, VerFarmaciaDirective, AdicionarCestaDirective],
 declarations: [NumberOnlyDirective,MaxLengthDirective, ImageZoomHoverDirective, VerFarmaciaDirective, AdicionarCestaDirective]
})
export class DirectiveModule {
}