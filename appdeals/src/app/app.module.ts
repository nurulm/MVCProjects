import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import {HeaderComponent} from './header/header.component';
import {FooterComponent} from "./footer/footer.component";
import {LoginComponent} from "./login/login.component";
import {RegisterComponent} from "./register/register.component";
import {ProductComponent} from "./products/products.component";

//import service

import {RegisterService} from './register/register.service'
import {ProductsService} from './Products/products.service'

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    LoginComponent,
    RegisterComponent,
    ProductComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [RegisterService],
  bootstrap: [AppComponent]
})
export class AppModule { }
