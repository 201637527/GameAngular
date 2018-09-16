import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ViewComponent } from './view/view.component';
import { SearchComponent } from './search/search.component';
import { AppRouterModule } from './app-router';
import { ServerService } from './server.service';
import { FormsModule } from '@angular/forms';
import { PipeFilter, PipeFilterId, PipeFilterPlay1, PipeFilterPlayer2, PipeFilterWhoWW} from './Pipe/PipeFilter';
import { HttpClientModule } from '@angular/common/http';
import { EditComponent } from './view/edit/edit.component';
import { NewGameComponent } from './new-game/new-game.component';
import { SearchAPIComponent } from './search-api/search-api.component';




@NgModule({
  declarations: [
    AppComponent,
    ViewComponent,
    SearchComponent,
    PipeFilter,
    PipeFilterId,
    PipeFilterPlay1,
    PipeFilterPlayer2,
    PipeFilterWhoWW,
    EditComponent,
    NewGameComponent,
    SearchAPIComponent

  ],
  imports: [
    BrowserModule,
    AppRouterModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [ServerService],
  bootstrap: [AppComponent]
})
export class AppModule { }
