import { Component, OnInit, Input } from '@angular/core';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'ngb-datepicker-popup',
  templateUrl: './datepicker-popup.html'
})

export class NgbDatePickerPopup implements OnInit {
  model: NgbDateStruct;

  @Input() placeholder: string;

  constructor() {
  }

  ngOnInit() {
  }
}
