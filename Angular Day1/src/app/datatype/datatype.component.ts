import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-datatype',
  templateUrl: './datatype.component.html',
  styleUrls: ['./datatype.component.css']
})
export class DatatypeComponent implements OnInit {
//declaring variables
name:string='LTI';
age:number;
hobbies:string[];
marks:Array<number>;
Istrue:boolean;
student:Object;
tupleval:[string,number,boolean];
dynamicvalue:any;

picture="assets/Images/Ball.jpg";

//Initializing variables
  constructor() {
    this.age=24;
    this.hobbies=["Singing","Cooking","Teaching"];
    this.marks=[90,89,85];
    this.Istrue=false;
    this.tupleval=["Prakash",30,true];
    this.student={fathersname:"Kumar", city:"Mumbai"}
    this.dynamicvalue="Hello";
    this.dynamicvalue=true;
   }

  ngOnInit(): void {
  }

}
