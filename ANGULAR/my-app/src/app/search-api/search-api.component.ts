import { ServerService } from './../server.service';
import { Game } from './../models';
import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-search-api',
  templateUrl: './search-api.component.html',
  styleUrls: ['./search-api.component.css']
})
export class SearchAPIComponent implements OnInit , OnDestroy {

  public arrGame: Game[];
  public searchInput: any;
  public str: string;
  public Subscription: Subscription;
  constructor(private server: ServerService) { }

  ngOnInit() {
  }
  onInput(search: any) {
    console.log(this.str);
    this.server.getAny(search, this.str).subscribe(res =>
      this.arrGame = res);

  }
  onInputRadio($event) {
    console.log(event);

  }
  ngOnDestroy(): void {

    if (this.Subscription !== undefined){
      this.Subscription.unsubscribe();
      }
  }

}
