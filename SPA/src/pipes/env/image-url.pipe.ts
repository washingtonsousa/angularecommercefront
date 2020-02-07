import { Pipe, PipeTransform } from '@angular/core';
import * as enviroment from "src/environments/environment";
import { DomSanitizer } from '@angular/platform-browser';
@Pipe({
    name: 'imageUrl'
})
export class ImageUrlPipe implements PipeTransform {
    constructor(protected sanitizer: DomSanitizer) {}

    transform(imagePath: any, type: any) {
        let path = enviroment.environment.imagesServerUrl + imagePath;
            let resource = null;
        switch (type) {
            case ('style'):
            resource =  this.sanitizer.bypassSecurityTrustStyle(path);
            break;
            case ('none'):
                resource =  path;
                break;
            default:
            resource = this.sanitizer.bypassSecurityTrustResourceUrl(path);
            break;
        }

        return resource;

    }

}