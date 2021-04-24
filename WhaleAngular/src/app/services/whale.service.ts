import { Injectable } from '@angular/core';
import { Whale } from '../models/whale';
import { WHALES } from './mock-whales';
import { Observable, of } from 'rxjs';
import { MessageService } from './message.service';

@Injectable({
  providedIn: 'root'
})
export class WhaleService {

  constructor(private messageService: MessageService) { }
  getWhales(): Observable<Whale[]> {
    const whales = of(WHALES);
    this.messageService.add('WhaleService: fetched whales');
    return whales;
  }
}
