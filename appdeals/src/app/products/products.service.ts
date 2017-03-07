import {Injectable} from '@angular/core';
import {Http} from '@angular/http';
import {Observable} from 'rxjs';
import 'rxjs';

@Injectable()
export class ProductsService{

    constructor (private http:Http){

    }
    
    GetProducts():Observable<any>
    {
        return this.http.get('./src/api/products.json')
                .map((res)=>res.json())
                .catch((error)=>error.json());
        //return [{Name:"IPhone", Model:"7s"},{Name:"Samsung", Model:"S7"}];
    }

    SearchProduct(){

    }
    AddProduct()
    {

    }

    ModifyProduct()
    {
    
    }

    DeleteProduct(){

    }

}
