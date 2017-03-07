import {Component} from '@angular/core';
import {ProductsService} from './products.service';


@Component({
    selector:"appdeal-product",
    templateUrl:"./products.component.html",
    providers:[ProductsService]
})
export class ProductComponent{
    
    constructor(private ProductSVC:ProductsService){
        this.getProducts();
    }
    products:any;
    getProducts(){
        this.ProductSVC.GetProducts()
        .subscribe(res=>{
            this.products = res;
        });
    }

    addProduct(){
        this.ProductSVC.AddProduct();
    }

    search(){
        this.ProductSVC.SearchProduct();
    }

    //Products = this.ProductSVC.GetProducts();
}