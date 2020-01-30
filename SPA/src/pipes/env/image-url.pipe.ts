import { Pipe, PipeTransform } from '@angular/core';
import * as enviroment from "src/environments/environment";
import { DomSanitizer } from '@angular/platform-browser';
@Pipe({
    name: 'imageUrl'
})
export class ImageUrlPipe implements PipeTransform {
    constructor(protected sanitizer: DomSanitizer) {}

    transform(imagePath: any) {

        return this.sanitizer.bypassSecurityTrustResourceUrl(enviroment.environment.imagesServerUrl + imagePath);

    }

}