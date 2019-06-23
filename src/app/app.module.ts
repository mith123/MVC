import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HelloworldComponent } from './helloworld/helloworld.component';
import { DatabaceComponent } from './databace/databace.component';
import { DbService } from './db.service';
import {FormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    HelloworldComponent,
    DatabaceComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule

  ],
  providers: [DbService],
  bootstrap: [AppComponent]
})
export class AppModule { }
