import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductlistComponent } from './productlist/productlist.component';
import { ProductServices } from './services/productServices';

@NgModule({
  declarations: [
    AppComponent,
    ProductlistComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [ProductServices],
  bootstrap: [AppComponent]
})
export class AppModule { }
