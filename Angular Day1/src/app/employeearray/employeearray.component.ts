import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employeearray',
  templateUrl: './employeearray.component.html',
  styleUrls: ['./employeearray.component.css']
})
export class EmployeearrayComponent implements OnInit {
people:any[]=[
  {"name":"Shan","age":22,"dept":"HR"},
  {"name":"Ravi","age":25,"dept":"HR"},
  {"name":"Sony","age":23,"dept":"Finance"},
  {"name":"Joe","age":24,"dept":"IT"},
]

  constructor() { }

  ngOnInit(): void {
  }

}
