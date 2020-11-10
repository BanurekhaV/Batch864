import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { ProductServices } from '../services/productServices';

@Component({
  selector: 'app-productlist',
  templateUrl: './productlist.component.html',
  styleUrls: ['./productlist.component.css']
 // providers:[ProductServices]registering services at the component level
  //service is exclusive to the component
})
export class ProductlistComponent implements OnInit {

  products:Product[];
  comptitle;
  //1. create a property of service type and instantiate it
  //productservice;            //DI, taking an injection or being injected with the dependency
  constructor(private prodservice : ProductServices) {
    //1.1 this.productservice=new ProductServices();//tight coupling
    
   }
 getProductDetails()
 {
  //this.products=this.productservice.getProducts();
  this.products=this.prodservice.getProducts();
  this.comptitle=this.prodservice.showTitle();
 }
 


  ngOnInit(): void {
    //this.getProductDetails();
  }

}
