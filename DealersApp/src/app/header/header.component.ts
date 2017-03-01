import {Component} from "@angular/core";

@Component({
    selector:"app-header",
    templateUrl:"./header.component.html"
})

export class HeaderComponent{
    //public member
    header={
        brandName:"Product Details"
    };
    showLink:boolean = true;

    clickMe()
    {
        if(this.showLink)
        {
            this.showLink=false;
        }
        else
        {
            this.showLink=true;
        }
        console.log('clicked');
    }

    handleKeyPress()
    {
        console.log('entering data');
    }

}
