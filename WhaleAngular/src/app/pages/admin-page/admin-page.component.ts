import { Component, OnInit } from '@angular/core';
import { Whale } from '../../models/whale';
import { WHALES } from '../../services/mock-whales';


@Component({
  selector: 'app-admin-page',
  templateUrl: './admin-page.component.html',
  styleUrls: ['./admin-page.component.css']
})
export class AdminPageComponent implements OnInit {

  constructor() { }
  whales = WHALES;
  selectedWhale?: Whale;
  onSelect(whale: Whale): void {
    this.selectedWhale = whale;
  }
  ngOnInit(): void {
  }

}
