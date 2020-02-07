import { NgModule } from "@angular/core";
import { ImageUrlPipe } from './image-url.pipe';

@NgModule({
    exports: [ImageUrlPipe],
    declarations: [ImageUrlPipe,]
})
export class PipeModule {

}