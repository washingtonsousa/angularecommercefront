import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginFormComponent } from './forms/cliente/login/login-form.component';
import { LoginService } from 'src/services/login.service';
import { CadastroFormComponent } from './forms/cliente/cadastro/cadastro-form.component';
import { FormComponentsModule } from 'src/components/forms/form-components.module';

@NgModule({
    providers: [LoginService],
    declarations: [LoginFormComponent, CadastroFormComponent],
    exports: [LoginFormComponent, CadastroFormComponent],
    imports: [BrowserModule, CommonModule, ReactiveFormsModule, FormComponentsModule]
})
export class ViewsModule {

}