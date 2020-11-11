import { Injectable } from '@angular/core';
import { Product } from '../models/product';

@Injectable()
export class ProductServices
{
     showTitle()
    {
        return "Learning Service via Dependency Injections";
    }
    public getProducts()
    {
    let products:Product[];
    products=[
     {"id":10,"desc":"Memory Card", "price":500},
     {"id": 11,"desc":"Pen Drive", "price":200},
     {"id": 12,"desc":"Power Bank", "price":100}
    ];
    return products;
    }

}