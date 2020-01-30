import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { NavigationModule } from 'src/navigation/navigation.module';
import { RouterModule, Routes } from '@angular/router';
import * as routing from "../shared/routing";
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ModalModule } from 'ngx-bootstrap';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    NavigationModule,
    ModalModule.forRoot(),
    TooltipModule.forRoot(),
    RouterModule.forRoot(
      routing.appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    ),
    NavigationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
