import { Game } from './../models';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { ServerService } from '../server.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit  , OnDestroy {

  public searchValue: any = '';
  public seachValID: any = '';
  public seachValPlay1: any = '';
  public seachValPlay2: any = '';
  public seachValWhoWW: any = '';
  public gameArr: Game[];
  public subscription: Subscription;

  constructor(private service: ServerService) { }

  ngOnInit() {
   this.subscription =  this.service.getAllGame().subscribe(games => {
      this.gameArr = games;
    });
  }
  onFocs() {
    this.seachValID =  '';
    this.seachValPlay1 = '';
    this.seachValPlay2 = '';
    this.seachValWhoWW = '';
    this.searchValue = '';
  }
  
  ngOnDestroy(): void {

    if (this.subscription !== undefined){
      this.subscription.unsubscribe();
      }
  }



}
