import { Pipe, PipeTransform } from '@angular/core';
import * as enviroment from "src/environments/environment";
import { DomSanitizer } from '@angular/platform-browser';
import { ImageUrlSetting } from './settings/image-url.setting';

@Pipe({
    name: 'imageUrl'
})
export class ImageUrlPipe implements PipeTransform {
    
    constructor(protected sanitizer: DomSanitizer) {}

    transform(imageName: any, settings: ImageUrlSetting = new ImageUrlSetting()) {

        let path = enviroment.environment.imagesServerUrl + settings.ImageTypePath + imageName;
        let resource = null;

        switch (settings.Type) {
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


