import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Customer } from '../models/customer';

@Component({
  selector: 'app-templatedform',
  templateUrl: './templatedform.component.html',
  styleUrls: ['./templatedform.component.css']
})
export class TemplatedformComponent implements OnInit {

 domain:string[]=["Angular","ReactJs","Node.Js","C#"]
  cust:Customer;
  constructor() {
    this.cust={
      custname:" ",
      age :0,
      mailid :" ",
    }
   }

onRegister(customerform:NgForm)
{
  console.log(customerform.value);
}

  ngOnInit(): void {
  }

}
