import {Component} from '@angular/core';
import {ProductsService} from './products.service';

@Component({
    selector:"appdeal-product",
    templateUrl:"./products.component.html",
    providers:[ProductsService]
})

export class ProductComponent{
    
    constructor(private ProductSVC:ProductsService){

    }

    Products = this.ProductSVC.GetProducts();
}