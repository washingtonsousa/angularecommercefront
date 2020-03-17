import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { NavigationModule } from 'src/navigation/navigation.module';
import { RouterModule } from '@angular/router';
import * as routing from "../shared/routing";
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ModalModule, TabsModule } from 'ngx-bootstrap';
import { MaterialModule } from 'src/components/material/material.module';
import { NgBrazil } from 'ng-brazil';
import { NgxMaskModule, IConfig } from 'ngx-mask'
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { TokenInterceptor } from 'src/services/interceptors/jwt-interceptor';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

export var options: Partial<IConfig> | (() => Partial<IConfig>);

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'serverApp' }),
    NavigationModule,
    MaterialModule,
    ModalModule.forRoot(),
    TooltipModule.forRoot(),
    TabsModule.forRoot(),
    BrowserAnimationsModule,
    NgxMaskModule.forRoot(options),
    NgBrazil,
    RouterModule.forRoot(routing.appRoutes, { enableTracing: false, initialNavigation: 'enabled' } // <-- debugging purposes only
),
    NavigationModule
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: TokenInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
