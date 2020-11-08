import { Component, OnInit } from '@angular/core';
import { Department } from '../models/department';

@Component({
  selector: 'app-cruddepartment',
  templateUrl: './cruddepartment.component.html',
  styleUrls: ['./cruddepartment.component.css']
})
export class CruddepartmentComponent implements OnInit {
dept:Department[]=[
  {deptid:101,dname:"Sales",location:"Pune"},
  {deptid:102,dname:"IT",location:"Chennai"},
  {deptid:103,dname:"HR",location:"Pune"},
  {deptid:104,dname:"Finance",location:"Mumbai"},
]

getdeptinfo:any={};
  constructor() { }

  //to add a new department
  addDepartment()
  {
    this.dept.push(this.getdeptinfo);
    this.getdeptinfo={};
  }

  //delete a department

  delDepartment(i)
  {
    console.log(i);
    this.dept.splice(i,1);
   }
   delDepartmentbyId(id:number)
   {
     for(let index=0;index<this.dept.length;index++)
     {
       console.log("inside delete by id",id);
       if(this.dept[index].deptid===id)
       {
         console.log('id:' + this.dept[index].deptid);
         this.dept.splice(index,1);
         this.err="record deleted";
         return true;
        }
        else{
          this.err="record not deleted";
        }
     }

   }
err;

indexvalue;
editDepartment(i)
{
  this.getdeptinfo.deptid=this.dept[i].deptid;
  this.getdeptinfo.dname=this.dept[i].dname;
  this.getdeptinfo.location=this.dept[i].location;
  this.indexvalue=i;
}

updateDepartment()
{
  let k=this.indexvalue;
  for(let i=0;i<this.dept.length;i++)
  {
    if(k==i)
    {
      this.dept[i]=this.getdeptinfo;
      this.getdeptinfo={};
    }
  }
}
  ngOnInit(): void {
  }

}
