import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import {Whale} from "../models/whale";
import {WHALES} from "./mock-whales";

@Injectable({
  providedIn: 'root'
})
export class WhaleService {

  constructor() { }
  getWhales(): Observable<Whale[]> {
    const whales = of(WHALES);
    return whales;
  }
}
