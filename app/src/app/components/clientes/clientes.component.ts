import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {
  angular= "https://angular.io/" 
  constructor() { }

  ngOnInit(): void {
  }
  nuevoCliente(){
    alert("asdads")
  }
}
