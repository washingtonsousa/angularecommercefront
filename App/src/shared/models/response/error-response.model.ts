import { HttpErrorResponse } from '@angular/common/http';

export class ErrorResponseModel  extends HttpErrorResponse {

    error: Notification[];


}

class Notification {

        Key: string;
        Value: string;
        Rank: number;

}