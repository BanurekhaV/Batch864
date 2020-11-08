import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DatatypeComponent } from './datatype/datatype.component';
import { EmployeearrayComponent } from './employeearray/employeearray.component';
import { TwowaybindingComponent } from './twowaybinding/twowaybinding.component';
import { EventbindingComponent } from './eventbinding/eventbinding.component';
import { CruddepartmentComponent } from './cruddepartment/cruddepartment.component';
import { TemplatedformComponent } from './templatedform/templatedform.component';

@NgModule({         //decorators-meta data information
  declarations: [
    AppComponent,
    DatatypeComponent,
    EmployeearrayComponent,
    TwowaybindingComponent,
    EventbindingComponent,
    CruddepartmentComponent,
    TemplatedformComponent
  ],
  imports: [      //inbuilt modules
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
