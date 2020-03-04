export class ResponseModel {
      Key : string;
      Value :string;
}

export class ResponseModelWithResult<T> extends ResponseModel {
    _result : T;
}