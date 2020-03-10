import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginFormComponent } from './forms/cliente/login/login-form.component';
import { LoginService } from 'src/services/login.service';

@NgModule({
    providers: [LoginService],
    declarations: [LoginFormComponent],
    exports: [LoginFormComponent],
    imports: [BrowserModule, CommonModule, ReactiveFormsModule]
})
export class ViewsModule {

}