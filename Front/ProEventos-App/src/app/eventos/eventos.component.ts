import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {

  public eventos: any =

    [
      {
        Tema: 'Ángular 11',
        Local: 'Belo Horizonte'
      },

      {
        Tema: 'NET 5',
        Local: 'Belo Horizonte'

      },

      {
        Tema: 'Ángular',
        Local: 'Belo Horizonte'

      }

    ]


}
