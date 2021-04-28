import { Component, OnInit } from '@angular/core';
import {Whale} from "../../models/whale";
import {WhaleService} from "../../services/whale.service";

@Component({
  selector: 'app-whales',
  templateUrl: './whales.component.html',
  styleUrls: ['./whales.component.css']
})
export class WhalesComponent implements OnInit {

  selectedWhale?: Whale;

  whales: Whale[] = [];
  constructor(private whaleService: WhaleService) { }

  ngOnInit() {
    this.getWhales();
  }
  onSelect(whale: Whale): void {
    this.selectedWhale = whale;
  }

  getWhales(): void {
    this.whaleService.getWhales()
        .subscribe(whales => this.whales = whales);
  }

}
