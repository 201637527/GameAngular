import { Game } from '../models';
import { PipeTransform, Pipe } from '@angular/core';




@Pipe({ name: 'PipeFilter' })

export class PipeFilter implements PipeTransform {
    public arrHlep: Game[] = [];


    transform( arrg: Game[], searchValue: string ): Game[] {
        if ( !arrg || !searchValue) {
           return arrg;
        }
        this.arrHlep = arrg.filter(
          arr => arr.Game_Name.toLowerCase().includes(searchValue.toLowerCase()));
          return this.arrHlep;
        }
      }



@Pipe({ name: 'PipeFilterId' })

export class PipeFilterId implements PipeTransform {
    public arrHlep: Game[] = [];


    transform( arrg: Game[], searchValueId: number ): Game[] {
        if ( !arrg || !searchValueId) {
           return arrg;
        }
        this.arrHlep = arrg.filter(
          arr => arr.ID == searchValueId);
        return this.arrHlep;
      }
    }

    @Pipe({ name: 'PipeFilterPlay1' })

export class PipeFilterPlay1 implements PipeTransform {
    public arrHlep: Game[] = [];


    transform( arrg: Game[], searchPlayer1: string ): Game[] {
        if ( !arrg || !searchPlayer1) {
           return arrg;
        }
        this.arrHlep = arrg.filter(
          arr => arr.Player_one.toLowerCase().includes(searchPlayer1.toLowerCase()));
        return this.arrHlep;
      }
    }
    @Pipe({ name: 'PipeFilterPlayer2' })

export class PipeFilterPlayer2 implements PipeTransform {
    public arrHlep: Game[] = [];


    transform( arrg: Game[], searchValueP2: string ): Game[] {
        if ( !arrg || !searchValueP2) {
           return arrg;
        }
        this.arrHlep = arrg.filter(
          arr => arr.Player_two.toLowerCase().includes(searchValueP2.toLowerCase()));
        return this.arrHlep;
      }
    }
    @Pipe({ name: 'PipeFilterWhoWW' })

export class PipeFilterWhoWW implements PipeTransform {
    public arrHlep: Game[] = [];


    transform( arrg: Game[], searchValww: string ): Game[] {
        if ( !arrg || !searchValww) {
           return arrg;
        }
        this.arrHlep = arrg.filter(
          arr => arr.who_won.toLowerCase().includes(searchValww.toLowerCase()));
        return this.arrHlep;
      }
    }
