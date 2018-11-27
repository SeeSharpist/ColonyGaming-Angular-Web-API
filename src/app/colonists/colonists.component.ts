import { Component, OnInit } from '@angular/core';

import { ColonistService } from '../services/colonist.service';
import { IColonist } from '../model/colonist';
import { Global } from '../shared/Global';

@Component({
  selector: 'app-colonists',
  templateUrl: './colonists.component.html',
  styleUrls: ['./colonists.component.css']
})
export class ColonistsComponent implements OnInit {

  colonistList: IColonist[];
  loadingState: boolean;

  constructor(private _colonistService: ColonistService) { }

  ngOnInit() {
    this.loadingState = true;
    this.loadColonists();
  }

  loadColonists(): void {
    this._colonistService.getAllColonists(Global.BASE_TWITCH_ENDPOINT + 'getAllLiveColonists')
      .subscribe(colonists => {
        this.loadingState = false;
        this.colonistList = colonists;
      });
  }

}
