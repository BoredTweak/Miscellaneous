import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HeaderComponent } from './@shared/header/header.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FooterComponent } from './@shared/footer/footer.component';

import { AppComponent } from './app.component';
import { Routes, RouterModule } from '@angular/router';
import { AppRouting } from './app.routing';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    DashboardComponent
  ],
  imports: [
    AppRouting,
    HttpClientModule,
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
