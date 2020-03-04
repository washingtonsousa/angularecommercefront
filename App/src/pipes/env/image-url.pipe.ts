import { Pipe, PipeTransform } from '@angular/core';
import * as enviroment from "src/environments/environment";
import { DomSanitizer } from '@angular/platform-browser';
import { ImageUrlSetting } from './settings/image-url.setting';
import { ImageTypesPaths } from 'src/shared/enums/image-type-paths';

@Pipe({
    name: 'imageUrl'
})
export class ImageUrlPipe implements PipeTransform {
    
    constructor(protected sanitizer: DomSanitizer) {}

    transform(imageName: any, ImageTypePath: ImageTypesPaths, Type: string = "none") {

        let imgTypePath =  ImageTypePath == undefined ? "" : ImageTypePath;

        let path = enviroment.environment.imagesServerUrl + imgTypePath + imageName;
        let resource = null;

        switch (Type) {
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


