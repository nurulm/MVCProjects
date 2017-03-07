import {Component} from "@angular/core"

@Component({
    selector:"appdeal-header",
    templateUrl:"./header.component.html"
})

export class HeaderComponent
{
    constructor(){

    }
    contentType:string = "";

    loadContent(item){
        this.contentType = item;
    }
    
}