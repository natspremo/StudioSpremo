import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomepageAdminComponent } from './components/homepage/homepage-admin/homepage-admin.component';
import { HomepageNonregComponent } from './components/homepage/homepage-nonreg/homepage-nonreg.component';
import { HomepageRegUserComponent } from './components/homepage/homepage-reg-user/homepage-reg-user.component';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { SignUpComponent } from './components/sign-up/sign-up.component';

const routes: Routes = [
  {
    path: "",
    redirectTo: "/homepage-nonreg",
    pathMatch: 'full'
  },
  {
    path: "homepage-nonreg",
    component: HomepageNonregComponent
  },
  {
    path: "homepage-reg",
    component: HomepageRegUserComponent
  },
  {
    path: "homepage-admin",
    component: HomepageAdminComponent
  },
  {
    path: "sign-in",
    component: SignInComponent
  },
  {
    path: "sign-up",
    component: SignUpComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
