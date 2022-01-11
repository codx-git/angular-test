import { Component, OnInit } from '@angular/core';
import { moduleAService } from '../services/module-a.service';

@Component({
  selector: 'lib-module-a',
  template: ` <p>module-a works!</p> `,
  styles: [],
})
export class moduleAComponent implements OnInit {
  constructor(private service: moduleAService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
