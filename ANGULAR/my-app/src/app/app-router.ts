import { EditComponent } from './view/edit/edit.component';

import { } from '@angular/forms';
import { RouterModule, Routes, ChildrenOutletContexts } from '@angular/Router';
import { NgModule } from '@angular/core';
import { ViewComponent } from './view/view.component';
import { SearchComponent } from './search/search.component';
import { NewGameComponent } from './new-game/new-game.component';
import { SearchAPIComponent } from './search-api/search-api.component';



const routes: Routes = [
    {path: 'view', component : ViewComponent, children : [
         {path: 'edit:id', component: EditComponent }
         ]},
    { path: 'search', component : SearchComponent },
    { path: 'new-Game', component : NewGameComponent },
    {path: 'searchAPI', component: SearchAPIComponent}
  ];
@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [RouterModule]
})
export class AppRouterModule {

}
