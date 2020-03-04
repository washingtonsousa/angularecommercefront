import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { ContextService } from 'src/services/storage/context.service';
import { ContextModel } from 'src/shared/models/context/context.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent  implements OnInit  {
  title = 'Farmácia mais próxima';
  constructor(private router: Router, private _contextService:ContextService) { }

  ngOnInit() {

    this._contextService.GetCurrentContext().subscribe( (result) => {

          if(result == undefined || result == null) {
            let contextModel = new ContextModel();
            this._contextService.SetCurrentContext(contextModel).subscribe(() => {})
          }

    }) 

    this.router.events.subscribe((evt) => {
        if (!(evt instanceof NavigationEnd)) {
            return;
        }
        window.scrollTo(0, 0)
    });
}
}
