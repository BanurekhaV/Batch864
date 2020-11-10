import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  public student={
    id:"",
    name:"",
    marks:""
     };

     public students=[
       {"id":10,"name":"Aneesh","marks":68},
       {"id":11,"name":"Rahul","marks":87},
       {"id":12,"name":"Suresh","marks":90},
       {"id":13,"name":"Anirudh","marks":78}
     ];
 constructor(private route:ActivatedRoute) { }

  ngOnInit() {
    //the snapshot does not refresh the data though the URL refreshes
   // this.student.id=this.route.snapshot.paramMap.get('id');
   // this.student.name=this.route.snapshot.paramMap.get('name');
  // with paramMaps.scusbribe, we can get notified as and ehen changes happen
  this.route.paramMap.subscribe((params : ParamMap)=>{
    this.student.id=params.get('id');
    this.student.name=params.get('name');
    
  });

  }

}
