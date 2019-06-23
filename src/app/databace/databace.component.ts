import { Component, OnInit } from '@angular/core';
import {NgForm} from '@angular/forms'
import { HttpClient } from '@angular/common/http';
import { DbService } from '../db.service';
import { Student } from '../student';

@Component({
  selector: 'app-databace',
  templateUrl: './databace.component.html',
  styleUrls: ['./databace.component.css']
})
export class DatabaceComponent implements OnInit 
{
  student=new Student();
  error='';
  success='';
  constructor(private service: DbService) 
  {
 
   }

  ngOnInit() 
  {
  }
  reg(frm: NgForm)
  {
    
  this.service.store(this.student).subscribe(data=>{this.success="sucesssfully inserted"; frm.resetForm()},
    
  (err)=>{this.error="error ocured";});
  }

}






