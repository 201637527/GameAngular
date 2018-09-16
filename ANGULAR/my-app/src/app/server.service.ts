import { Injectable } from '@angular/core';

import { Game } from './models';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Options } from 'selenium-webdriver/opera';





@Injectable({
  providedIn: 'root'
})
export class ServerService {

  constructor(private _http: HttpClient) {

  }
  getAllGame(): Observable<Game[]> {
    return this._http.get<Game[]>('http://localhost:49357/api/game');
  }
  getAny(search: any , str: string): Observable<Game[]> {
    return this._http.get<Game[]>('http://localhost:49357/api/game/search?' + str + '=' + search);
  }

  getIdGame(id: number): Observable<Game> {
    return this._http.get<Game>('http://localhost:49357/api/game' + id);
  }
  post(game: Game): Observable<Response> {
    return this._http.post<Response>('http://localhost:49357/api/game', game);
  }
  put(game: Game): Observable<string>  {
    return this._http.put<string>('http://localhost:49357/api/game/' + game.ID, game);
  }

  delet(id: number): Observable<string> {
    return this._http.delete<string>('http://localhost:49357/api/game/' + id);
  }
}
