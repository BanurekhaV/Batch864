import { Component, OnInit } from '@angular/core';
import { stringify } from 'querystring';

@Component({
  selector: 'app-eventbinding',
  templateUrl: './eventbinding.component.html',
  styleUrls: ['./eventbinding.component.css']
})
export class EventbindingComponent implements OnInit {
  count:number;
  ctr:number;
  togglestar:Boolean;
    clsname:String;
  constructor() {
    this.count=0;
    this.ctr=0;
    this.togglestar=false;
    this.clsname="glyphicon glyphicon-star-empty";
   }
  //star toggling
   changeStar()
   {
     this.togglestar=!this.togglestar;
     if(this.togglestar)
     this.clsname="glyphicon glyphicon-star";
     else
     this.clsname="glyphicon glyphicon-star-empty";
   }

   //likes and dislikes
   thumbsUp()
   {
     this.count+=1;
   }

   thumbsDown()
   {
     this.ctr+=1;
   }
   //general message function
   welcomeMsg()
   {
     alert("I Welcome All to Angular session");
   }

 //user input
 fname;
 displayfullName(uname:HTMLInputElement)
 {
   this.fname=uname.value+"Sharma";
 }

  ngOnInit(): void {
  }

}
