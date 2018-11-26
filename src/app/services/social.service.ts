import { Injectable } from '@angular/core';

import { Social } from '../model/social';

@Injectable({
  providedIn: 'root'
})
export class SocialService {
   socials: Social[] = [
    new Social('discord', 'https://discord.gg/qvJrmub', 'fa-discord'),
    new Social('twitter', 'http://www.twitter.com/TheColonyGaming', 'fa-twitter'),
    new Social('instagram', 'http://www.instagram.com/TheColonyGaming', 'fa-instagram')
  ];

  constructor() { }

  getSocials(): Social[] {

    return this.socials;
  }
}