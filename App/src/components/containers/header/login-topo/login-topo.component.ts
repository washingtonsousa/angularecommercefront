import { Component, OnInit } from '@angular/core';
import { Observable} from 'rxjs';
import { JwtLoggedInData } from 'src/shared/models/jwt/logged-in-data';
import { LoginService } from 'src/services/login.service';

@Component({
    selector: "login-topo",
    templateUrl: "login-topo.component.html"
})
export class LoginTopoComponent implements OnInit {

        Cliente$: Observable<JwtLoggedInData>;

        constructor(private _loginService:LoginService) {}

        Logout() {
            this._loginService.fullLogOut();
        }

        ngOnInit() {
            this.Cliente$ = this._loginService.currentClienteLoggedIn.asObservable();
        }

}