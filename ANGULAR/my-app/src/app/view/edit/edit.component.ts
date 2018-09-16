import { ServerService } from './../../server.service';
import { Game } from './../../models';
import { Component, OnInit, Input, EventEmitter, Output, OnDestroy } from '@angular/core';
import { Router } from '@angular/Router';
import { Subscription } from 'rxjs';



@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit , OnDestroy {


  @Input() putData: Game;

  public massege: string;
  public data: Game;
 
 
  public subscription: Subscription;

  constructor(private server: ServerService, private route: Router) {

  }
  ngOnInit() {



  }

  onUpdata(data: Game) {
   this.subscription = this.server.put(data).subscribe(res => this.massege = res);

    // this.route.navigateByUrl('/search');


  }
  onDelet(id: number) {
    this.subscription = this.server.delet(id).subscribe(res => this.massege = res);

    // this.route.navigateByUrl('/search');

  }
  onNew() {
    this.route.navigateByUrl('/new-Game');
  }

  ngOnDestroy(): void {

    if (this.subscription !== undefined) {
      this.subscription.unsubscribe();
      }
  }


}
