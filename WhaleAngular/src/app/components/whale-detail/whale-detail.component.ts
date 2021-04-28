import { Component, OnInit, Input } from '@angular/core';
import {Whale} from "../../models/whale";

@Component({
  selector: 'app-whale-detail',
  templateUrl: './whale-detail.component.html',
  styleUrls: ['./whale-detail.component.css']
})
export class WhaleDetailComponent implements OnInit {

  @Input() whale?: Whale;
  constructor() { }

  ngOnInit(){
  }

}
