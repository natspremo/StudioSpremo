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
import { ContactUsComponent } from './components/contact-us/contact-us.component';
import { FooterComponent } from './components/footer/footer.component';
import { CarouselComponent } from './components/homepage/carousel/carousel.component';
import { HomepageDataComponent } from './components/homepage/homepage-data/homepage-data.component';
import { TnavbarNonregComponent } from './components/navbar-transparent/tnavbar-nonreg/tnavbar-nonreg.component';
import { TnavbarRegComponent } from './components/navbar-transparent/tnavbar-reg/tnavbar-reg.component';
import { NewFlexoJobComponent } from './components/new-flexo-job/new-flexo-job.component';
import { NewOffsetJobComponent } from './components/new-offset-job/new-offset-job.component';
import { AdminNotificationsComponent } from './components/admin-notifications/admin-notifications.component';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';
import { HpDataAdminComponent } from './components/homepage/homepage-admin/hp-data-admin/hp-data-admin.component';
import { AdminScheduleComponent } from './components/admin-schedule/admin-schedule.component';
import { AdminTableFlexoComponent } from './components/admin-table-flexo/admin-table-flexo.component';
import { AdminTableOffsetComponent } from './components/admin-table-offset/admin-table-offset.component';
import { AdminOtpremniceComponent } from './components/admin-otpremnice/admin-otpremnice.component';
import { AdminContactsComponent } from './components/admin-contacts/admin-contacts.component';
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
    SignUpComponent,
    ContactUsComponent,
    FooterComponent,
    CarouselComponent,
    HomepageDataComponent,
    TnavbarNonregComponent,
    TnavbarRegComponent,
    NewFlexoJobComponent,
    NewOffsetJobComponent,
    AdminNotificationsComponent,
    AdminDashboardComponent,
    HpDataAdminComponent,
    AdminScheduleComponent,
    AdminTableFlexoComponent,
    AdminTableOffsetComponent,
    AdminOtpremniceComponent,
    AdminContactsComponent
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
