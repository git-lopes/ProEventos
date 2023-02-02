import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos : any = [
    {
      Tema: 'Angular 15',
      Local: 'Fortaleza'
    },
    {
      Tema: '.NET 6.0',
      Local: 'Fortaleza - UNIFOR'
    }
  ]

  constructor() { }

  ngOnInit() {
  }

}
