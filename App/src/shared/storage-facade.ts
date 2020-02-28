import * as localforage from "localforage"; 


export class StorageFacade {

        private static localForage;

        private static Start() {
            // this.localForage = localforage;

            // this.localForage.config({
            //     driver      : localforage.LOCALSTORAGE, 
            //     name        : 'fp',
            //     version     : 1.0,
            //     size        : 4980736, 
            //     storeName   : 'keyvaluepairs', 
            //     description : 'some description'
            // });
        } 

        static getInstance() {

            // if(this.localForage == null || this.localForage == undefined) {
            //     this.Start();
            // }

            // return localforage;
        }



}