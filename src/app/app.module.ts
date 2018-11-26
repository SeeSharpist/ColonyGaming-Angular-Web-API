import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { Routing } from './app.routing';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { LayoutModule } from '@angular/cdk/layout';
import { AppMaterialModule } from './app.material.module';
import { ContactformComponent } from './contactform/contactform.component';
import { ContactlistComponent } from './contactlist/contactlist.component';

import { HomeComponent } from './home/home.component';
import { NavbarComponent } from './navbar/navbar.component';
import { SocialListComponent } from './social-list/social-list.component';

// Import ngx-twitter-timeline
import { NgxTwitterTimelineModule } from 'ngx-twitter-timeline';
import { TwitterFeedComponent } from './twitter-feed/twitter-feed.component';

//Import Services
import { ContactService } from './services/contact.service';
import { SocialService } from './services/social.service';
import { ColonistsComponent } from './colonists/colonists.component';

@NgModule({
  declarations: [
    AppComponent,
    ContactformComponent,
    ContactlistComponent,
    HomeComponent,
    TwitterFeedComponent,
    NavbarComponent,
    SocialListComponent,
    ColonistsComponent,

  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,    
    HttpClientModule,
    AppMaterialModule,
    FormsModule,
    ReactiveFormsModule,
    LayoutModule,
    Routing,
    NgxTwitterTimelineModule.forRoot()
  ],
  providers: [
    ContactService,
    SocialService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
