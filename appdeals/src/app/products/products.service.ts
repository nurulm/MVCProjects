import {Injectable} from '@angular/core';

@Injectable()
export class ProductsService{
    
    GetProducts()
    {
        return [{Name:"IPhone", Model:"7s"},{Name:"Samsung", Model:"S7"}];
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
