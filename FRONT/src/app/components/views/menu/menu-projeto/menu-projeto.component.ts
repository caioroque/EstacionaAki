import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu-projeto',
  templateUrl: './menu-projeto.component.html',
  styleUrls: ['./menu-projeto.component.css']
})
export class MenuProjetoComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

}
