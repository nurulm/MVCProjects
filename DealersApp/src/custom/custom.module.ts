/* Creating the module
1. expor the class 
2. Decorators. @NgModule
@NgModule is a function name(params:type) {
    it will help you to bind different features of your module
    and you can export them.
}
*/

import {NgModule} from '@angular/core'
import { BrowserModule } from '@angular/platform-browser';

import {AppModule} from "../app/app.module";

import {CustomComponent} from "./custom.component";

@NgModule({
    imports: [
    BrowserModule,
    AppModule
  ],
   declarations: [
    CustomComponent
  ],
  bootstrap: [CustomComponent]
})

export class CustomModule{}