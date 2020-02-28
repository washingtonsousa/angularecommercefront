import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { NavigationModule } from 'src/navigation/navigation.module';
import { RouterModule } from '@angular/router';
import * as routing from "../shared/routing";
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ModalModule, TabsModule } from 'ngx-bootstrap';
import { MaterialModule } from 'src/components/material/material.module';

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
    RouterModule.forRoot(routing.appRoutes, { enableTracing: true, initialNavigation: 'enabled' } // <-- debugging purposes only
),
    NavigationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
