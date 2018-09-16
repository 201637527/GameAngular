import { Game } from './../models';

import { Component, OnInit, Input, Output, EventEmitter, OnDestroy } from '@angular/core';
import { ServerService } from '../server.service';

import {  ActivatedRoute, Router } from '@angular/Router';
import { Subscription, Observer } from 'rxjs';



@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit , OnDestroy {
  public datag: Game;
  public arrgame: Game[];
  public Subscription: Subscription;
  constructor(public service:  ServerService , private route: Router) { }

  ngOnInit() {
   this.Subscription = this.service.getAllGame().subscribe(games => {
      this.arrgame = games;
    });
  }
  onClick(data: Game, event) {
    this.datag = data;


  }
  onrRef() {

    this.Subscription = this.service.getAllGame().subscribe( games => this.arrgame = games);
  }
  onNew() {
    this.route.navigateByUrl('/new-Game');
  }
  ngOnDestroy(): void {

    if (this.Subscription !== undefined){
      this.Subscription.unsubscribe();
      }
  }
 

}


