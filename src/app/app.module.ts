import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomepageNonregComponent } from './components/homepage/homepage-nonreg/homepage-nonreg.component';
import { HomepageRegUserComponent } from './components/homepage/homepage-reg-user/homepage-reg-user.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { NavbarRegComponent } from './components/navbar/navbar-reg/navbar-reg.component';
import { NavbarAdminComponent } from './components/navbar/navbar-admin/navbar-admin.component';
import { HomepageAdminComponent } from './components/homepage/homepage-admin/homepage-admin.component';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { SignUpComponent } from './components/sign-up/sign-up.component';
@NgModule({
  declarations: [
    AppComponent,
    HomepageNonregComponent,
    HomepageRegUserComponent,
    NavbarComponent,
    NavbarRegComponent,
    NavbarAdminComponent,
    HomepageAdminComponent,
    SignInComponent,
    SignUpComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
