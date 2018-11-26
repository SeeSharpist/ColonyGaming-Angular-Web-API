import { Component, OnInit } from '@angular/core';
import { SocialService } from '../services/social.service';

@Component({
  selector: 'app-social-list',
  templateUrl: './social-list.component.html',
  styleUrls: ['./social-list.component.css']
})
export class SocialListComponent implements OnInit {

  socials = [];

  constructor(private socialService: SocialService) {}

  ngOnInit() {
    this.socials = this.socialService.getSocials();
  }

}
