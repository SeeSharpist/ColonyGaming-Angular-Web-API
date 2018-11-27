import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { ContactlistComponent } from './contactlist/contactlist.component';
import { ContactformComponent } from './contactform/contactform.component';
import { HomeComponent } from './home/home.component';
import { ColonistsComponent } from './colonists/colonists.component';

const appRoutes: Routes = [
  { path: '',  pathMatch: 'full' , component: HomeComponent },
  { path: 'contacts', component: ContactlistComponent },
  { path: 'contactform', component: ContactformComponent },
  { path: 'home', component: HomeComponent },
  { path: 'colonists', component: ColonistsComponent },
];

export const Routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);
