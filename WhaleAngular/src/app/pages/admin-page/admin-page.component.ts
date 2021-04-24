import { Component, OnInit } from '@angular/core';
import { Whale } from '../../models/whale';
import { WHALES } from '../../services/mock-whales';
import { WhaleService } from '../../services/whale.service';
import { MessageService } from '../../services/message.service'


@Component({
  selector: 'app-admin-page',
  templateUrl: './admin-page.component.html',
  styleUrls: ['./admin-page.component.css']
})
export class AdminPageComponent implements OnInit {

  constructor(private whaleService: WhaleService, private messageService: MessageService) { }
  whales: Whale[] = [];
  //whales = WHALES;
  selectedWhale?: Whale;
  onSelect(whale: Whale): void {
    this.selectedWhale = whale;
    this.messageService.add(`WhalesComponent: Selected whale id=${whale.id}`);
  }
  getWhales(): void {
    this.whaleService.getWhales()
        .subscribe(whales => this.whales = whales);
  }
  ngOnInit(): void {
    this.getWhales();
  }

}
