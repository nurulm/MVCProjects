import {Component} from "@angular/core"
import {RegisterService} from './register.service'

@Component({
    selector:"appdeal-register",
    templateUrl:"./register.component.html"
})

export class RegisterComponent 
{
    user:Object ={
        email : "nurul.ameen@gmail.com"
    }

    constructor(private RegisterSVC:RegisterService)
    {
        
    }
    countries = this.RegisterSVC.GetCountries(); // [{ name: "India", code: "IN" }, { name: "United States", code: "USA" }];

    countrySelected(){

    }
    
    create(){
        console.log(this.user);
    }
}