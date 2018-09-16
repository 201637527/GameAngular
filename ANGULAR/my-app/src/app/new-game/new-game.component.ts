import { Router } from '@angular/Router';
import { Game } from './../models';
import { ServerService } from './../server.service';
import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { throwError, Subscription } from 'rxjs';

@Component({
  selector: 'app-new-game',
  templateUrl: './new-game.component.html',
  styleUrls: ['./new-game.component.css']
})
export class NewGameComponent implements OnInit , OnDestroy {

  gameNew: Game = new Game();
  subscription: Subscription;

  constructor(private server: ServerService, private router: Router) { }

  ngOnInit() {

  }
  onSave() {
    console.log(this.gameNew);
    this.subscription =  this.server.post(this.gameNew).subscribe( (res) =>
    console.log('creat' + res));
    this.router.navigateByUrl('/view');

  }

  ngOnDestroy(): void {
    if (this.subscription !== undefined){
    this.subscription.unsubscribe();
    }
  }

}
