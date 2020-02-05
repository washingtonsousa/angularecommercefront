import { GlobalEventEmittersService } from './global-event-emitters.service';

export class LoadingIconService {

    static show() {
        GlobalEventEmittersService.get("loading-icon-evt").emit({  Show: true });
    }

    static hide() {
        GlobalEventEmittersService.get("loading-icon-evt").emit({  Show: false });
    }


}