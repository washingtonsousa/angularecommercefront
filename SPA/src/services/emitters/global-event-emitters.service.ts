import { EventEmitter } from '@angular/core';

export class GlobalEventEmittersService {

    private static events: EventEmitter<any>[] = [];

        static get(eventName) : EventEmitter<any> {

            if(this.events[eventName] == null || this.events[eventName] == undefined) {
                            this.events[eventName] = new EventEmitter<any>();
            }

            return this.events[eventName];
        }

}