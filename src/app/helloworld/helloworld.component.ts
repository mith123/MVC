import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-helloworld',
  templateUrl: './helloworld.component.html',
  styleUrls: ['./helloworld.component.css']
})
export class HelloworldComponent implements OnInit {
user:any;
collapse:boolean=true;
  constructor() {
    this.user={name:'Ansa',job:'Student'};
  }
   toggle(){
     this.collapse=!this.collapse;
   }

  ngOnInit() {
  }

}
